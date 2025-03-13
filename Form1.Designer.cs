namespace MediaModToolKit
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mediaTabControl = new System.Windows.Forms.TabControl();
            this.tabPageVideos = new System.Windows.Forms.TabPage();
            this.tabPageComics = new System.Windows.Forms.TabPage();
            this.tabPageAudiobooks = new System.Windows.Forms.TabPage();
            this.tabPageMusic = new System.Windows.Forms.TabPage();
            this.tabPageVideoGames = new System.Windows.Forms.TabPage();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.recursiveCheckBox = new System.Windows.Forms.CheckBox();
            this.removeYearsCheckBox = new System.Windows.Forms.CheckBox();
            this.removeQualityTagsCheckBox = new System.Windows.Forms.CheckBox();
            this.removeTorrentTagsCheckBox = new System.Windows.Forms.CheckBox();
            this.preserveFullEpisodeTitlesCheckBox = new System.Windows.Forms.CheckBox();
            this.apiKeysTextBox = new System.Windows.Forms.TextBox();
            this.imdbApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.tmdbApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.thetvdbApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.anidbApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.opensubtitlesApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.comicVineApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.audibleApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.libriVoxApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.musicBrainzApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.lastFmApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.igdbApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.gameTdbApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.saveAPIKeysButton = new System.Windows.Forms.Button();
            this.refreshAPIKeysButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.saveDefaultsButton = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // mediaTabControl
            // 
            this.mediaTabControl.Controls.Add(this.tabPageVideos);
            this.mediaTabControl.Controls.Add(this.tabPageComics);
            this.mediaTabControl.Controls.Add(this.tabPageAudiobooks);
            this.mediaTabControl.Controls.Add(this.tabPageMusic);
            this.mediaTabControl.Controls.Add(this.tabPageVideoGames);
            this.mediaTabControl.Location = new System.Drawing.Point(12, 12);
            this.mediaTabControl.Name = "mediaTabControl";
            this.mediaTabControl.SelectedIndex = 0;
            this.mediaTabControl.Size = new System.Drawing.Size(600, 400);
            this.mediaTabControl.TabIndex = 0;
            this.mediaTabControl.SelectedIndexChanged += new System.EventHandler(this.mediaTabControl_SelectedIndexChanged);
            // 
            // tabPageVideos
            // 
            this.tabPageVideos.Location = new System.Drawing.Point(4, 29);
            this.tabPageVideos.Name = "tabPageVideos";
            this.tabPageVideos.Size = new System.Drawing.Size(592, 367);
            this.tabPageVideos.TabIndex = 0;
            this.tabPageVideos.Text = "Videos";
            this.tabPageVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.tabPageVideos.UseVisualStyleBackColor = false;
            // 
            // tabPageComics
            // 
            this.tabPageComics.Location = new System.Drawing.Point(4, 29);
            this.tabPageComics.Name = "tabPageComics";
            this.tabPageComics.Size = new System.Drawing.Size(592, 367);
            this.tabPageComics.TabIndex = 1;
            this.tabPageComics.Text = "Comics & Books";
            this.tabPageComics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.tabPageComics.UseVisualStyleBackColor = false;
            // 
            // tabPageAudiobooks
            // 
            this.tabPageAudiobooks.Location = new System.Drawing.Point(4, 29);
            this.tabPageAudiobooks.Name = "tabPageAudiobooks";
            this.tabPageAudiobooks.Size = new System.Drawing.Size(592, 367);
            this.tabPageAudiobooks.TabIndex = 2;
            this.tabPageAudiobooks.Text = "Audiobooks";
            this.tabPageAudiobooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPageAudiobooks.UseVisualStyleBackColor = false;
            // 
            // tabPageMusic
            // 
            this.tabPageMusic.Location = new System.Drawing.Point(4, 29);
            this.tabPageMusic.Name = "tabPageMusic";
            this.tabPageMusic.Size = new System.Drawing.Size(592, 367);
            this.tabPageMusic.TabIndex = 3;
            this.tabPageMusic.Text = "Music";
            this.tabPageMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.tabPageMusic.UseVisualStyleBackColor = false;
            // 
            // tabPageVideoGames
            // 
            this.tabPageVideoGames.Location = new System.Drawing.Point(4, 29);
            this.tabPageVideoGames.Name = "tabPageVideoGames";
            this.tabPageVideoGames.Size = new System.Drawing.Size(592, 367);
            this.tabPageVideoGames.TabIndex = 4;
            this.tabPageVideoGames.Text = "Video Games";
            this.tabPageVideoGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(193)))));
            this.tabPageVideoGames.UseVisualStyleBackColor = false;
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.Location = new System.Drawing.Point(12, 420);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.Size = new System.Drawing.Size(500, 29);
            this.folderPathTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(518, 420);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(90, 30);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "📁 Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // recursiveCheckBox
            // 
            this.recursiveCheckBox.AutoSize = true;
            this.recursiveCheckBox.Location = new System.Drawing.Point(12, 455);
            this.recursiveCheckBox.Name = "recursiveCheckBox";
            this.recursiveCheckBox.Size = new System.Drawing.Size(134, 24);
            this.recursiveCheckBox.TabIndex = 3;
            this.recursiveCheckBox.Text = "📂 Scan Subfolders";
            this.recursiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeYearsCheckBox
            // 
            this.removeYearsCheckBox.AutoSize = true;
            this.removeYearsCheckBox.Location = new System.Drawing.Point(150, 455);
            this.removeYearsCheckBox.Name = "removeYearsCheckBox";
            this.removeYearsCheckBox.Size = new System.Drawing.Size(117, 24);
            this.removeYearsCheckBox.TabIndex = 4;
            this.removeYearsCheckBox.Text = "📅 Remove Years";
            this.removeYearsCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeQualityTagsCheckBox
            // 
            this.removeQualityTagsCheckBox.AutoSize = true;
            this.removeQualityTagsCheckBox.Location = new System.Drawing.Point(270, 455);
            this.removeQualityTagsCheckBox.Name = "removeQualityTagsCheckBox";
            this.removeQualityTagsCheckBox.Size = new System.Drawing.Size(172, 24);
            this.removeQualityTagsCheckBox.TabIndex = 5;
            this.removeQualityTagsCheckBox.Text = "🎥 Remove Quality Tags";
            this.removeQualityTagsCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeTorrentTagsCheckBox
            // 
            this.removeTorrentTagsCheckBox.AutoSize = true;
            this.removeTorrentTagsCheckBox.Location = new System.Drawing.Point(450, 455);
            this.removeTorrentTagsCheckBox.Name = "removeTorrentTagsCheckBox";
            this.removeTorrentTagsCheckBox.Size = new System.Drawing.Size(172, 24);
            this.removeTorrentTagsCheckBox.TabIndex = 6;
            this.removeTorrentTagsCheckBox.Text = "🌐 Remove Torrent Tags";
            this.removeTorrentTagsCheckBox.UseVisualStyleBackColor = true;
            // 
            // preserveFullEpisodeTitlesCheckBox
            // 
            this.preserveFullEpisodeTitlesCheckBox.AutoSize = true;
            this.preserveFullEpisodeTitlesCheckBox.Location = new System.Drawing.Point(12, 485);
            this.preserveFullEpisodeTitlesCheckBox.Name = "preserveFullEpisodeTitlesCheckBox";
            this.preserveFullEpisodeTitlesCheckBox.Size = new System.Drawing.Size(226, 24);
            this.preserveFullEpisodeTitlesCheckBox.TabIndex = 7;
            this.preserveFullEpisodeTitlesCheckBox.Text = "📺 Preserve Full Episode Titles";
            this.preserveFullEpisodeTitlesCheckBox.UseVisualStyleBackColor = true;
            // 
            // apiKeysTextBox
            // 
            this.apiKeysTextBox.Location = new System.Drawing.Point(650, 100);
            this.apiKeysTextBox.Multiline = true;
            this.apiKeysTextBox.Name = "apiKeysTextBox";
            this.apiKeysTextBox.ReadOnly = true;
            this.apiKeysTextBox.Size = new System.Drawing.Size(350, 150);
            this.apiKeysTextBox.TabIndex = 8;
            // 
            // imdbApiKeyTextBox
            // 
            this.imdbApiKeyTextBox.Location = new System.Drawing.Point(650, 260);
            this.imdbApiKeyTextBox.Name = "imdbApiKeyTextBox";
            this.imdbApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.imdbApiKeyTextBox.TabIndex = 9;
            this.imdbApiKeyTextBox.Visible = false;
            // 
            // tmdbApiKeyTextBox
            // 
            this.tmdbApiKeyTextBox.Location = new System.Drawing.Point(650, 295);
            this.tmdbApiKeyTextBox.Name = "tmdbApiKeyTextBox";
            this.tmdbApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.tmdbApiKeyTextBox.TabIndex = 10;
            this.tmdbApiKeyTextBox.Visible = false;
            // 
            // thetvdbApiKeyTextBox
            // 
            this.thetvdbApiKeyTextBox.Location = new System.Drawing.Point(650, 330);
            this.thetvdbApiKeyTextBox.Name = "thetvdbApiKeyTextBox";
            this.thetvdbApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.thetvdbApiKeyTextBox.TabIndex = 11;
            this.thetvdbApiKeyTextBox.Visible = false;
            // 
            // anidbApiKeyTextBox
            // 
            this.anidbApiKeyTextBox.Location = new System.Drawing.Point(650, 365);
            this.anidbApiKeyTextBox.Name = "anidbApiKeyTextBox";
            this.anidbApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.anidbApiKeyTextBox.TabIndex = 12;
            this.anidbApiKeyTextBox.Visible = false;
            // 
            // opensubtitlesApiKeyTextBox
            // 
            this.opensubtitlesApiKeyTextBox.Location = new System.Drawing.Point(650, 400);
            this.opensubtitlesApiKeyTextBox.Name = "opensubtitlesApiKeyTextBox";
            this.opensubtitlesApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.opensubtitlesApiKeyTextBox.TabIndex = 13;
            this.opensubtitlesApiKeyTextBox.Visible = false;
            // 
            // comicVineApiKeyTextBox
            // 
            this.comicVineApiKeyTextBox.Location = new System.Drawing.Point(650, 260);
            this.comicVineApiKeyTextBox.Name = "comicVineApiKeyTextBox";
            this.comicVineApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.comicVineApiKeyTextBox.TabIndex = 14;
            this.comicVineApiKeyTextBox.Visible = false;
            // 
            // audibleApiKeyTextBox
            // 
            this.audibleApiKeyTextBox.Location = new System.Drawing.Point(650, 260);
            this.audibleApiKeyTextBox.Name = "audibleApiKeyTextBox";
            this.audibleApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.audibleApiKeyTextBox.TabIndex = 15;
            this.audibleApiKeyTextBox.Visible = false;
            // 
            // libriVoxApiKeyTextBox
            // 
            this.libriVoxApiKeyTextBox.Location = new System.Drawing.Point(650, 295);
            this.libriVoxApiKeyTextBox.Name = "libriVoxApiKeyTextBox";
            this.libriVoxApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.libriVoxApiKeyTextBox.TabIndex = 16;
            this.libriVoxApiKeyTextBox.Visible = false;
            // 
            // musicBrainzApiKeyTextBox
            // 
            this.musicBrainzApiKeyTextBox.Location = new System.Drawing.Point(650, 260);
            this.musicBrainzApiKeyTextBox.Name = "musicBrainzApiKeyTextBox";
            this.musicBrainzApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.musicBrainzApiKeyTextBox.TabIndex = 17;
            this.musicBrainzApiKeyTextBox.Visible = false;
            // 
            // lastFmApiKeyTextBox
            // 
            this.lastFmApiKeyTextBox.Location = new System.Drawing.Point(650, 295);
            this.lastFmApiKeyTextBox.Name = "lastFmApiKeyTextBox";
            this.lastFmApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.lastFmApiKeyTextBox.TabIndex = 18;
            this.lastFmApiKeyTextBox.Visible = false;
            // 
            // igdbApiKeyTextBox
            // 
            this.igdbApiKeyTextBox.Location = new System.Drawing.Point(650, 260);
            this.igdbApiKeyTextBox.Name = "igdbApiKeyTextBox";
            this.igdbApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.igdbApiKeyTextBox.TabIndex = 19;
            this.igdbApiKeyTextBox.Visible = false;
            // 
            // gameTdbApiKeyTextBox
            // 
            this.gameTdbApiKeyTextBox.Location = new System.Drawing.Point(650, 295);
            this.gameTdbApiKeyTextBox.Name = "gameTdbApiKeyTextBox";
            this.gameTdbApiKeyTextBox.Size = new System.Drawing.Size(350, 29);
            this.gameTdbApiKeyTextBox.TabIndex = 20;
            this.gameTdbApiKeyTextBox.Visible = false;
            // 
            // saveAPIKeysButton
            // 
            this.saveAPIKeysButton.Location = new System.Drawing.Point(650, 455);
            this.saveAPIKeysButton.Name = "saveAPIKeysButton";
            this.saveAPIKeysButton.Size = new System.Drawing.Size(80, 30);
            this.saveAPIKeysButton.TabIndex = 21;
            this.saveAPIKeysButton.Text = "💾 Save";
            this.saveAPIKeysButton.UseVisualStyleBackColor = true;
            this.saveAPIKeysButton.Click += new System.EventHandler(this.SaveAPIKeysButton_Click);
            // 
            // refreshAPIKeysButton
            // 
            this.refreshAPIKeysButton.Location = new System.Drawing.Point(740, 455);
            this.refreshAPIKeysButton.Name = "refreshAPIKeysButton";
            this.refreshAPIKeysButton.Size = new System.Drawing.Size(80, 30);
            this.refreshAPIKeysButton.TabIndex = 22;
            this.refreshAPIKeysButton.Text = "🔄 Refresh";
            this.refreshAPIKeysButton.UseVisualStyleBackColor = true;
            this.refreshAPIKeysButton.Click += new System.EventHandler(this.RefreshAPIKeysButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(830, 455);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(80, 30);
            this.previewButton.TabIndex = 23;
            this.previewButton.Text = "👁️ Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(920, 455);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(80, 30);
            this.applyButton.TabIndex = 24;
            this.applyButton.Text = "✅ Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(650, 490);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 30);
            this.startButton.TabIndex = 25;
            this.startButton.Text = "🚀 Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // saveDefaultsButton
            // 
            this.saveDefaultsButton.Location = new System.Drawing.Point(740, 490);
            this.saveDefaultsButton.Name = "saveDefaultsButton";
            this.saveDefaultsButton.Size = new System.Drawing.Size(80, 30);
            this.saveDefaultsButton.TabIndex = 26;
            this.saveDefaultsButton.Text = "💾 Defaults";
            this.saveDefaultsButton.UseVisualStyleBackColor = true;
            this.saveDefaultsButton.Click += new System.EventHandler(this.SaveDefaultsButton_Click);
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.ItemHeight = 20;
            this.fileListBox.Location = new System.Drawing.Point(650, 12);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(350, 84);
            this.fileListBox.TabIndex = 27;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.saveDefaultsButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.refreshAPIKeysButton);
            this.Controls.Add(this.saveAPIKeysButton);
            this.Controls.Add(this.gameTdbApiKeyTextBox);
            this.Controls.Add(this.igdbApiKeyTextBox);
            this.Controls.Add(this.lastFmApiKeyTextBox);
            this.Controls.Add(this.musicBrainzApiKeyTextBox);
            this.Controls.Add(this.libriVoxApiKeyTextBox);
            this.Controls.Add(this.audibleApiKeyTextBox);
            this.Controls.Add(this.comicVineApiKeyTextBox);
            this.Controls.Add(this.opensubtitlesApiKeyTextBox);
            this.Controls.Add(this.anidbApiKeyTextBox);
            this.Controls.Add(this.thetvdbApiKeyTextBox);
            this.Controls.Add(this.tmdbApiKeyTextBox);
            this.Controls.Add(this.imdbApiKeyTextBox);
            this.Controls.Add(this.apiKeysTextBox);
            this.Controls.Add(this.preserveFullEpisodeTitlesCheckBox);
            this.Controls.Add(this.removeTorrentTagsCheckBox);
            this.Controls.Add(this.removeQualityTagsCheckBox);
            this.Controls.Add(this.removeYearsCheckBox);
            this.Controls.Add(this.recursiveCheckBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.mediaTabControl);
            this.Name = "Form1";
            this.Text = "Wade’s Media Mod ToolKit";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TabControl mediaTabControl;
        private System.Windows.Forms.TabPage tabPageVideos;
        private System.Windows.Forms.TabPage tabPageComics;
        private System.Windows.Forms.TabPage tabPageAudiobooks;
        private System.Windows.Forms.TabPage tabPageMusic;
        private System.Windows.Forms.TabPage tabPageVideoGames;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.CheckBox recursiveCheckBox;
        private System.Windows.Forms.CheckBox removeYearsCheckBox;
        private System.Windows.Forms.CheckBox removeQualityTagsCheckBox;
        private System.Windows.Forms.CheckBox removeTorrentTagsCheckBox;
        private System.Windows.Forms.CheckBox preserveFullEpisodeTitlesCheckBox;
        private System.Windows.Forms.TextBox apiKeysTextBox;
        private System.Windows.Forms.TextBox imdbApiKeyTextBox;
        private System.Windows.Forms.TextBox tmdbApiKeyTextBox;
        private System.Windows.Forms.TextBox thetvdbApiKeyTextBox;
        private System.Windows.Forms.TextBox anidbApiKeyTextBox;
        private System.Windows.Forms.TextBox opensubtitlesApiKeyTextBox;
        private System.Windows.Forms.TextBox comicVineApiKeyTextBox;
        private System.Windows.Forms.TextBox audibleApiKeyTextBox;
        private System.Windows.Forms.TextBox libriVoxApiKeyTextBox;
        private System.Windows.Forms.TextBox musicBrainzApiKeyTextBox;
        private System.Windows.Forms.TextBox lastFmApiKeyTextBox;
        private System.Windows.Forms.TextBox igdbApiKeyTextBox;
        private System.Windows.Forms.TextBox gameTdbApiKeyTextBox;
        private System.Windows.Forms.Button saveAPIKeysButton;
        private System.Windows.Forms.Button refreshAPIKeysButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button saveDefaultsButton;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}