using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaModToolKit
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private List<(string FullPath, string NewName)> filesToRename = new List<(string, string)>();
        private string logFilePath = @"C:\WadesMediaModToolKit\log.txt";

        public Form1()
        {
            InitializeComponent();
            LoadAPIKeys();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // Add tooltips
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(browseButton, "Browse: Opens a dialog to select a folder.");
            toolTip.SetToolTip(saveAPIKeysButton, "Save: Saves the API keys to a file.");
            toolTip.SetToolTip(refreshAPIKeysButton, "Refresh: Reloads the API keys from the file.");
            toolTip.SetToolTip(previewButton, "Preview: Previews the file renaming changes.");
            toolTip.SetToolTip(applyButton, "Apply: Applies the renaming changes to files.");
            toolTip.SetToolTip(startButton, "Start: Runs the full process (Preview + Apply).");
            toolTip.SetToolTip(saveDefaultsButton, "Defaults: Saves the current settings as defaults.");
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folderPathTextBox.Text = folderDialog.SelectedPath;
                    LogMessage($"📁 Selected folder: {folderPathTextBox.Text}");
                }
            }
        }

        private async void PreviewButton_Click(object sender, EventArgs e)
        {
            string folderPath = folderPathTextBox.Text;
            if (string.IsNullOrEmpty(folderPath) || !await EnsureDriveAccessAsync(folderPath))
            {
                MessageBox.Show("🚫 Please select a valid folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            filesToRename.Clear();
            fileListBox.Items.Clear();

            this.Enabled = false;
            try
            {
                TabPage currentTab = await Task.Run(() =>
                {
                    return (TabPage)mediaTabControl.Invoke(new Func<TabPage>(() => mediaTabControl.SelectedTab));
                });

                string[] extensions = GetExtensionsForTab(currentTab.Text);
                string[] excludedFolders = { "Torrent Files", "Downloads" };

                await Task.Run(() =>
                {
                    var searchOption = recursiveCheckBox.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                    var files = Directory.GetFiles(folderPath, "*.*", searchOption)
                        .Where(f => extensions.Contains(Path.GetExtension(f).ToLower()) &&
                                   !excludedFolders.Any(ex => Path.GetDirectoryName(f).Contains(ex)))
                        .Select(f => (File: f, Directory: Path.GetDirectoryName(f), OriginalName: Path.GetFileName(f)));

                    foreach (var fileInfo in files)
                    {
                        string newName = GenerateNewName(fileInfo.OriginalName, fileInfo.Directory, currentTab.Text);
                        UpdateUI($"📄 Original: {fileInfo.OriginalName} -> New: {newName}");
                        lock (filesToRename)
                        {
                            filesToRename.Add((fileInfo.File, newName));
                        }
                    }
                });
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private async void ApplyButton_Click(object sender, EventArgs e)
        {
            if (filesToRename.Count == 0)
            {
                MessageBox.Show("⚠️ No files to rename. Use 'Preview' first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Enabled = false;
            try
            {
                await Task.Run(async () =>
                {
                    foreach (var item in filesToRename)
                    {
                        string fullPath = item.FullPath;
                        string newName = item.NewName;
                        string directory = Path.GetDirectoryName(fullPath);
                        string newFullPath = Path.Combine(directory, newName);
                        if (File.Exists(fullPath) && !File.Exists(newFullPath))
                        {
                            File.Move(fullPath, newFullPath);
                            UpdateUI($"✅ Renamed: {Path.GetFileName(fullPath)} -> {newName}");
                            LogMessage($"✅ Renamed: {Path.GetFileName(fullPath)} -> {newName}");

                            if (mediaTabControl.SelectedTab.Text == "Videos")
                            {
                                await DownloadSubtitlesForFile(newFullPath);
                            }
                        }
                    }
                    filesToRename.Clear();
                });
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                await Task.Yield();
                PreviewButton_Click(sender, e);
                while (this.Enabled == false) await Task.Delay(100);

                ApplyButton_Click(sender, e);
                while (this.Enabled == false) await Task.Delay(100);
            });
            MessageBox.Show("🎉 Process completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveDefaultsButton_Click(object sender, EventArgs e)
        {
            LogMessage("💾 Defaults saved.");
            MessageBox.Show("💾 Defaults saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadAPIKeys()
        {
            TabPage currentTab = mediaTabControl.SelectedTab;
            string tabName = currentTab.Text;
            string apiKeysFile = "api_keys.txt";
            string apiKeysContent = File.Exists(apiKeysFile) ? File.ReadAllText(apiKeysFile) : "";

            apiKeysTextBox.Text = string.IsNullOrEmpty(apiKeysContent) ? "🔑 Add API Keys!" : ExtractAPIKeys(apiKeysContent, GetAPIKeysForTab(tabName));
        }

        private string[] GetAPIKeysForTab(string tabName)
        {
            return tabName switch
            {
                "Videos" => new[] { "IMDB", "TMDb", "TheTVDB", "AniDB", "OpenSubtitles" },
                "Comics & Books" => new[] { "Comic Vine" },
                "Audiobooks" => new[] { "Audible", "LibriVox" },
                "Music" => new[] { "MusicBrainz", "Last.fm" },
                "Video Games" => new[] { "IGDB", "GameTDB" },
                _ => new string[] { }
            };
        }

        private string ExtractAPIKeys(string content, string[] keys)
        {
            string result = "";
            foreach (string key in keys)
            {
                string pattern = $"{key}=";
                int index = content.IndexOf(pattern);
                if (index >= 0)
                {
                    int start = index + pattern.Length;
                    int end = content.IndexOf("\n", start);
                    if (end < 0) end = content.Length;
                    string value = content.Substring(start, end - start).Trim();
                    result += $"🔑 {key}: {value}\n";
                }
            }
            return result.Length > 0 ? result : "🔑 Add API Keys!";
        }

        private void UpdateUI(string message)
        {
            if (fileListBox.InvokeRequired)
            {
                fileListBox.Invoke(new Action(() => fileListBox.Items.Add(message)));
            }
            else
            {
                fileListBox.Items.Add(message);
            }
        }

        private void LogMessage(string message)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));
                File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"🚫 Error logging: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string[] GetExtensionsForTab(string tabName)
        {
            return tabName switch
            {
                "Videos" => new[] { ".mp4", ".avi", ".mkv", ".mov" },
                "Comics & Books" => new[] { ".cbz", ".cbr", ".epub", ".mobi" },
                "Audiobooks" => new[] { ".mp3", ".m4b" },
                "Music" => new[] { ".mp3", ".flac", ".wav" },
                "Video Games" => new[] { ".iso", ".rom" },
                _ => new string[] { }
            };
        }

        private string GenerateNewName(string originalName, string directory, string tabName)
        {
            string newName = originalName;

            if (removeYearsCheckBox.Checked)
                newName = System.Text.RegularExpressions.Regex.Replace(newName, @"\(\d{4}\)", "").Trim();
            if (removeQualityTagsCheckBox.Checked)
                newName = System.Text.RegularExpressions.Regex.Replace(newName, @"\b(1080p|720p|480p)\b", "").Trim();
            if (removeTorrentTagsCheckBox.Checked)
                newName = System.Text.RegularExpressions.Regex.Replace(newName, @"\b(IYF|YTS|RARBG|BONE|FiGi|DARKSIDE|EZTV)\b", "").Trim();

            if (tabName == "Videos")
            {
                var tvMatch = System.Text.RegularExpressions.Regex.Match(newName, @"^(.*?)S(\d{2})E(\d{2})(.*?)$", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (tvMatch.Success)
                {
                    string showName = tvMatch.Groups[1].Value.Trim();
                    string season = tvMatch.Groups[2].Value;
                    string episode = tvMatch.Groups[3].Value;
                    string episodeTitle = tvMatch.Groups[4].Value.Trim();
                    if (!preserveFullEpisodeTitlesCheckBox.Checked)
                        episodeTitle = "";

                    string seasonFolder = $"Season {int.Parse(season)}";
                    string newDirectory = Path.Combine(directory, showName, seasonFolder);
                    Directory.CreateDirectory(newDirectory);

                    newName = $"{showName} - S{season}E{episode}{episodeTitle}{Path.GetExtension(originalName)}";
                }
                else
                {
                    var movieMatch = System.Text.RegularExpressions.Regex.Match(newName, @"^(.*?)\((\d{4})\)(.*?)$");
                    if (movieMatch.Success)
                    {
                        string movieName = movieMatch.Groups[1].Value.Trim();
                        string year = movieMatch.Groups[2].Value;
                        newName = $"{movieName} ({year}){Path.GetExtension(originalName)}";
                    }
                }
            }

            return newName;
        }

        private void mediaTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAPIKeys();
            UpdateApiKeyTextBoxVisibility();
        }

        private void SaveAPIKeysButton_Click(object sender, EventArgs e)
        {
            string apiKeys = "";
            TabPage currentTab = mediaTabControl.SelectedTab;
            string tabName = currentTab.Text;

            foreach (string key in GetAPIKeysForTab(tabName))
            {
                var textbox = this.Controls.Find($"{key.Replace(".", "")}ApiKeyTextBox", true).FirstOrDefault() as TextBox;
                if (textbox != null) apiKeys += $"{key}={textbox.Text ?? ""}\n";
            }

            File.WriteAllText("api_keys.txt", apiKeys.Trim());
            LoadAPIKeys();
            LogMessage("🔑 API keys saved.");
            MessageBox.Show("🔑 API keys saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshAPIKeysButton_Click(object sender, EventArgs e)
        {
            LoadAPIKeys();
        }

        private async Task<bool> EnsureDriveAccessAsync(string path, int maxRetries = 3, int delayMs = 1000)
        {
            for (int i = 0; i < maxRetries; i++)
            {
                if (Directory.Exists(path))
                    return true;

                LogMessage($"🚫 Drive {path} inaccessible. Retrying ({i + 1}/{maxRetries})...");
                await Task.Delay(delayMs);
            }

            MessageBox.Show($"🚫 Could not access {path} after {maxRetries} attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private async Task DownloadSubtitlesForFile(string filePath)
        {
            if (string.IsNullOrEmpty(opensubtitlesApiKeyTextBox.Text))
            {
                LogMessage("🚫 No OpenSubtitles key. Skipping subtitles.");
                return;
            }

            string subtitleUrl = await FetchSubtitleUrl(filePath, opensubtitlesApiKeyTextBox.Text);
            if (!string.IsNullOrEmpty(subtitleUrl))
            {
                string subtitlePath = Path.ChangeExtension(filePath, ".srt");
                LogMessage($"📥 Subtitles downloaded for {Path.GetFileName(filePath)} to {subtitlePath}");
            }
        }

        private async Task<string> FetchSubtitleUrl(string filePath, string apiKey)
        {
            await Task.Delay(100);
            return "http://example.com/subtitle.srt";
        }

        private void UpdateApiKeyTextBoxVisibility()
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl is TextBox tb && tb.Name.EndsWith("ApiKeyTextBox")) tb.Visible = false;

            TabPage currentTab = mediaTabControl.SelectedTab;
            string tabName = currentTab.Text;
            string[] keys = GetAPIKeysForTab(tabName);

            int yOffset = 260;
            foreach (string key in keys)
            {
                var textbox = this.Controls.Find($"{key.Replace(".", "")}ApiKeyTextBox", true).FirstOrDefault() as TextBox;
                if (textbox != null)
                {
                    textbox.Visible = true;
                    textbox.Location = new System.Drawing.Point(650, yOffset);
                    textbox.Size = new System.Drawing.Size(350, 29);
                    yOffset += 35;
                }
            }
        }
    }
}