Guide to Setting Up API Keys for “Wade’s Media Mod ToolKit”
This guide is designed for users of “Wade’s Media Mod ToolKit” (Revision 1.3 Alpha) to set up API keys for various media databases, allowing the application to cross-reference and rename files for Videos, Comics, Books, Audiobooks, Music, and Video Games (including Emulator Files). Each API key is managed in-app via the GUI, and the tool will use these keys to fetch metadata, improve renaming accuracy, and download subtitles (for videos). Here’s how to obtain and configure each API key, along with its intended purpose in the tool.

1. IMDB (via OMDB API)
Purpose in Tool: Cross-references movie and TV show titles, years, and metadata for the Videos tab to ensure accurate renaming and metadata matching for movies and series.
Setup Steps:
Visit the OMDB API website: http://www.omdbapi.com/.
OMDB offers a free API key, but it’s limited to 1,000 daily requests. Register by providing your email to get an API key (no account creation needed).
Copy the API key provided in the email or on the website.
In “Wade’s Media Mod ToolKit,” go to the Videos tab, locate the “Enter IMDB API Key” text box under “API Keys,” paste the key, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use IMDB Database” checkbox to enable IMDB cross-referencing for video files.
Notes: OMDB is an unofficial wrapper for IMDb data, free for non-commercial use, but it may require upgrading to a paid plan for higher usage. Ensure your usage complies with OMDB’s terms (e.g., no redistribution of data).
2. TMDb (The Movie Database)
Purpose in Tool: Cross-references movie, TV show, and anime titles, years, and metadata for the Videos tab, providing detailed information for accurate renaming and metadata matching.
Setup Steps:
Visit https://www.themoviedb.org/ and create a free account (register with email or social media).
Log in, navigate to your account settings, and click “API” on the left sidebar.
Follow the instructions to generate a new API key (v3 API is recommended). You’ll need to agree to TMDb’s terms of use (free for non-commercial use, up to 40 requests per 10 seconds).
Copy the API key provided.
In “Wade’s Media Mod ToolKit,” go to the Videos tab, locate the “Enter TMDb API Key” text box under “API Keys,” paste the key, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use TMDb Database” checkbox to enable TMDb cross-referencing for video files.
Notes: TMDb supports both movies and TV shows, making it ideal for your Videos tab. It’s widely used, well-documented, and free for non-commercial projects, but rate limits apply.
3. TheTVDB
Purpose in Tool: Cross-references TV show titles, episode numbers, and metadata for the Videos tab, particularly for series and anime, ensuring accurate renaming for TV content.
Setup Steps:
Visit https://thetvdb.com/ and create a free account (register with email).
Log in, navigate to your account settings, and request an API key for v4 (the current version, replacing v2 as of October 2021). You may need to wait for approval or provide project details.
Once approved, you’ll receive an API key (free for non-commercial use, but rate limits or subscription fees may apply for heavy usage).
Copy the API key provided.
In “Wade’s Media Mod ToolKit,” go to the Videos tab, locate the “Enter TheTVDB API Key” text box under “API Keys,” paste the key, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use TheTVDB Database” checkbox to enable TheTVDB cross-referencing for video files.
Notes: TheTVDB focuses on TV shows and is ideal for series metadata, but its v4 API requires registration and may have limitations for free users. Ensure compliance with their terms (e.g., no scraping or unauthorized data use).
4. AniDB
Purpose in Tool: Cross-references anime titles, episode numbers, and metadata for the Videos tab, ensuring accurate renaming for anime content within TV shows or movies.
Setup Steps:
Visit https://anidb.net/ and create a free account (register with email or username).
Log in and navigate to the API section (typically under developer tools or forums). AniDB uses an XML-RPC API, which requires setting up a client or script to generate a session key (no traditional API key).
Follow their documentation to obtain a client ID and generate a session key (free for non-commercial use, but requires understanding XML-RPC or third-party libraries like AniDBSharp or PyAnime).
For simplicity, use a placeholder in the “Enter AniDB API Key” text box (e.g., your username or client ID), and I’ll help implement the XML-RPC integration later.
In “Wade’s Media Mod ToolKit,” go to the Videos tab, locate the “Enter AniDB API Key” text box under “API Keys,” paste your placeholder, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use AniDB Database” checkbox to enable AniDB cross-referencing for video files.
Notes: AniDB is anime-specific, free, and community-driven, but its API is less straightforward (XML-RPC). I’ll provide detailed implementation steps for the CrossReferenceWithAniDB method in a future revision once you have the setup details.
5. Comic Vine
Purpose in Tool: Cross-references comic book titles, issue numbers, and metadata for the Comics tab, ensuring accurate renaming for comic files (e.g., .cbr, .cbz).
Setup Steps:
Visit https://comicvine.gamespot.com/api/ and create a free account (register with email or social media on Gamespot).
Log in, navigate to the API section, and request an API key (free for non-commercial use, up to 1,000 requests per day).
Copy the API key provided after approval (may take a few hours or days).
In “Wade’s Media Mod ToolKit,” go to the Comics tab, locate the “Enter Comic Vine API Key” text box under “API Keys,” paste the key, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use Comic Vine Database” checkbox to enable Comic Vine cross-referencing for comic files.
Notes: Comic Vine is ideal for comics, free for non-commercial use, but rate limits apply. Ensure compliance with their terms (e.g., no caching or redistribution of data).
6. Google Books
Purpose in Tool: Cross-references book titles, authors, and metadata for the Books tab, ensuring accurate renaming for book files (e.g., .pdf, .epub, .mobi).
Setup Steps:
Visit https://developers.google.com/books and sign in with a Google account.
Navigate to the Google Cloud Console (console.cloud.google.com), create a project, and enable the Books API.
Generate an API key under “APIs & Services” > “Credentials” (free for up to 1,000 requests per day, with potential charges for higher usage).
Copy the API key provided.
In “Wade’s Media Mod ToolKit,” go to the Books tab, locate the “Enter Google Books API Key” text box under “API Keys,” paste the key, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use Google Books Database” checkbox to enable Google Books cross-referencing for book files.
Notes: Google Books is free for low usage, but you may need a billing account for higher requests. Ensure compliance with Google’s terms (e.g., no scraping or unauthorized use).
7. Open Library
Purpose in Tool: Cross-references book titles, authors, and metadata for the Books tab, providing an open-source alternative for book renaming (e.g., .pdf, .epub, .mobi).
Setup Steps:
Visit https://openlibrary.org/ and create a free account (register with email).
Navigate to the developer documentation (openlibrary.org/dev/docs/api) to access their API, which doesn’t require a traditional API key but uses OAuth or simple HTTP requests.
For simplicity, use a placeholder in the “Enter Open Library API Key” text box (e.g., “openlibrary” or leave it blank), as Open Library’s API is open-access but may require authentication for advanced features.
In “Wade’s Media Mod ToolKit,” go to the Books tab, locate the “Enter Open Library API Key” text box under “API Keys,” paste your placeholder, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use Open Library Database” checkbox to enable Open Library cross-referencing for book files.
Notes: Open Library is free and open-source, ideal for public domain books, but its API is less structured than others. I’ll help implement the HTTP requests in a future revision.
8. Audible
Purpose in Tool: Cross-references audiobook titles, authors, and metadata for the Audiobooks tab, ensuring accurate renaming for audiobook files (e.g., .mp3, .m4b, .wav, .flac).
Setup Steps:
Visit https://developer.audible.com/ and create an account (register with email, may require a business or developer partnership).
Apply for API access, which typically requires a commercial relationship or partnership (not free for individual developers, but limited free access may be available for testing).
If granted, you’ll receive an API key or OAuth credentials. For now, use a placeholder in the “Enter Audible API Key” text box (e.g., “audible” or your account ID).
In “Wade’s Media Mod ToolKit,” go to the Audiobooks tab, locate the “Enter Audible API Key” text box under “API Keys,” paste your placeholder, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use Audible Database” checkbox to enable Audible cross-referencing for audiobook files.
Notes: Audible’s API is not freely available for individuals and requires a partnership. For now, use LibriVox as a free alternative; I’ll refine this integration later if you secure access.
9. LibriVox
Purpose in Tool: Cross-references public domain audiobook titles, authors, and metadata for the Audiobooks tab, ensuring accurate renaming for free audiobook files (e.g., .mp3, .m4b, .wav, .flac).
Setup Steps:
Visit https://librivox.org/ and create a free account (register with email).
Navigate to the developer documentation (librivox.org/wiki/index.php/Developer_Information) to access their API, which is open-access and doesn’t require a traditional API key but uses simple HTTP requests or RSS feeds.
Use a placeholder in the “Enter LibriVox API Key” text box (e.g., “librivox” or leave it blank), as LibriVox’s API is open-access.
In “Wade’s Media Mod ToolKit,” go to the Audiobooks tab, locate the “Enter LibriVox API Key” text box under “API Keys,” paste your placeholder, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use LibriVox Database” checkbox to enable LibriVox cross-referencing for audiobook files.
Notes: LibriVox is free and open-source, ideal for public domain audiobooks, but its API is basic. I’ll help implement the HTTP requests in a future revision.
10. MusicBrainz
Purpose in Tool: Cross-references music titles, artists, and metadata for the Music tab, ensuring accurate renaming for music files (e.g., .mp3, .wav, .flac, .aac, .m4a).
Setup Steps:
Visit https://musicbrainz.org/ and create a free account (register with email).
Navigate to the API documentation (musicbrainz.org/doc/MusicBrainz_API) to access their API, which doesn’t require a traditional API key but uses a user-agent string for identification.
Generate a user-agent string (e.g., “WadesMediaModToolKit/1.3 (your.email@example.com)”), and use it as a placeholder in the “Enter MusicBrainz API Key” text box.
In “Wade’s Media Mod ToolKit,” go to the Music tab, locate the “Enter MusicBrainz API Key” text box under “API Keys,” paste your user-agent, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use MusicBrainz Database” checkbox to enable MusicBrainz cross-referencing for music files.
Notes: MusicBrainz is free and open-source, ideal for music metadata, but requires a user-agent for API access. Ensure compliance with their terms (e.g., no excessive requests without rate limiting).
11. Last.fm
Purpose in Tool: Cross-references music titles, artists, and metadata for the Music tab, providing an alternative for music renaming (e.g., .mp3, .wav, .flac, .aac, .m4a).
Setup Steps:
Visit https://www.last.fm/api/ and create a free account (register with email).
Log in, navigate to the API section, and request an API key (free for non-commercial use, up to 1,000 requests per day, with potential charges for higher usage).
Copy the API key provided after approval (instant or within hours).
In “Media Mod ToolKit,” go to the Music tab, locate the “Enter Last.fm API Key” text box under “API Keys,” paste the key, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use Last.fm Database” checkbox to enable Last.fm cross-referencing for music files.
Notes: Last.fm is free for low usage, ideal for music metadata, but rate limits apply. Ensure compliance with their terms (e.g., no unauthorized data use).
12. IGDB (Internet Game Database)
Purpose in Tool: Cross-references video game titles, platforms, and metadata for the Video Games tab, ensuring accurate renaming for game files (e.g., .iso, .rom, .nes, .snes, etc., including Emulator Files).
Setup Steps:
Visit https://www.igdb.com/api/ and create a free account (register with email).
Log in, navigate to the API section, and request an API key (free for non-commercial use, up to 4,000 requests per month, with potential charges for higher usage).
Copy the API key provided after approval (instant or within hours).
In “Wade’s Media Mod ToolKit,” go to the Video Games tab, locate the “Enter IGDB API Key” text box under “API Keys,” paste the key, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use IGDB Database” checkbox to enable IGDB cross-referencing for game files.
Notes: IGDB is ideal for video games, free for non-commercial use, but rate limits apply. Ensure compliance with their terms (e.g., no scraping or unauthorized data use).
13. GameTDB
Purpose in Tool: Cross-references video game titles, platforms, and metadata for the Video Games tab, providing an alternative for game renaming (e.g., .iso, .rom, .nes, .snes, etc., including Emulator Files).
Setup Steps:
Visit https://www.gametdb.com/ and create a free account (register with email or username, may require forum registration).
Navigate to the API documentation (gametdb.com/api) to access their API, which may not require a traditional API key but uses simple HTTP requests or requires a user-agent.
Use a placeholder in the “Enter GameTDB API Key” text box (e.g., “gametdb” or your user-agent string like “WadesMediaModToolKit/1.3 (your.email@example.com)”).
In “Wade’s Media Mod ToolKit,” go to the Video Games tab, locate the “Enter GameTDB API Key” text box under “API Keys,” paste your placeholder, and click “Save API Keys” to store it in api_keys.txt.
Use the “Use GameTDB Database” checkbox to enable GameTDB cross-referencing for game files.
Notes: GameTDB is free and open-source, ideal for emulator games, but its API is basic. I’ll help implement the HTTP requests in a future revision.
Integrating API Keys into “Wade’s Media Mod ToolKit”
In-App Management: All API keys are managed in the GUI under the “API Keys” section for each tab (Videos, Comics, Books, Audiobooks, Music, Video Games). Enter the key in the respective text box (e.g., “Enter IMDB API Key” for IMDB), click “Save API Keys” to update api_keys.txt, and use “Refresh API Keys” to view or reload the file contents in the API Keys File (api_keys.txt) text box.
Cross-Referencing: Once a key is saved, check the corresponding database checkbox (e.g., “Use IMDB Database” for Videos) to enable cross-referencing. The tool will fetch metadata (titles, years, authors, etc.) to refine file names during renaming.
Subtitles (Videos Only): For the Videos tab, use the “Download Subtitles” checkbox and “Enter OpenSubtitles API Key” to enable subtitle downloading, following the same setup process as above (register at https://www.opensubtitles.org/ for a free key).
Notes and Considerations
Free vs. Paid: Most APIs here are free for non-commercial use with rate limits (e.g., TMDb, MusicBrainz, IGDB). IMDB (via OMDB) and Audible may require paid plans for higher usage or commercial projects. Ensure your usage aligns with each API’s terms of service (e.g., no redistribution, proper attribution).
Rate Limits: Monitor usage to avoid exceeding free limits (e.g., 1,000 requests/day for OMDB, 40 requests/10 seconds for TMDb). Implement rate limiting or caching in future revisions if needed.
Security: API keys are stored in plain text in api_keys.txt for simplicity (Alpha version). For production, encrypt or use a secure config file (e.g., JSON with encryption). I’ll provide updates for this if requested.
Implementation: The CrossReferenceWith… methods in Form1.cs are placeholders. I’ll provide detailed instructions to implement each API using HttpClient and JSON parsing (e.g., with Newtonsoft.Json via NuGet) in a future revision once you have the keys.
Dependencies: Ensure Newtonsoft.Json is installed via NuGet (right-click project > Manage NuGet Packages > Search for “Newtonsoft.Json” > Install) for JSON parsing in API calls.
