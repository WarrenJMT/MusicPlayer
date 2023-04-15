

using WMPLib; // Imported the Windows Media Player Library by adding a COM reference.  

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {

        private int currentIndex = 0;
        private string[] playlist = { "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Maddy Soma - Hit ittt.mp3",                                                   // Each song's path should be listed in the playlist string I believe?
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\[XG TAPE #2] Surround Sound (TEST VIDEO  COCONA).mp3",
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Ainsi bas la vida.mp3",
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Keith Ape - Hydro Ninja (Official Music Video).mp3",
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Apashe - Behind My Eyes (ft. LIA) [Official Music Video].mp3",
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Baby Gang - Alcott Zara Bershka [Official Video].mp3",
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Ghali  MOON RAGE feat. Axell (prod. Vaporstef) [Lyrics Video].mp3",
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Comethazine - 500 Hours (Official Audio).mp3",
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Hideyoshi - Euphoria feat. Jin Dogg (Official Video).mp3",
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Hideyoshi - Go feat. Benjazzy  [Prod. ZOT on the WAVE] (Official Video).mp3",
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Stromae - Santé (Official Music Video).mp3",
                                      "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\Sub Urban - BANDIT [Official Music Video].mp3",
        };


        private string[] playlistImages = { "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Images\\Music Note.png" };
        private string currentSongPath;
        private string currentImagePath;
        private bool isPaused = false;
        private bool isPlaying = false;
        private WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer(); // Have to declare the mediaPlayer before using it.



        public MusicPlayer()

        {
            InitializeComponent();
            mediaPlayer = new WindowsMediaPlayer();

        }



        private void PlayPauseButton_Click(object sender, EventArgs e)  // trying to get this to play and pause the media player (Done)
        {

            // This should return if the playlist is empty
            if (playlist.Length == 0) return;

            // This should check if the media player is playing.
            bool isPlaying = (mediaPlayer.playState == WMPPlayState.wmppsPlaying);

            if (mediaPlayer.playState == WMPPlayState.wmppsPaused || mediaPlayer.playState == WMPPlayState.wmppsStopped)
            {
                mediaPlayer.controls.play();
                isPaused = false;
            }
            else if (mediaPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                mediaPlayer.controls.pause();
                isPaused = true;
            }
        }

        // Trying to add WindowsMediaPlayer Functions. (Done)

        private void SongArt_Click(object sender, EventArgs e)
        {
            // I don't think this needs a function? 
        }

        // C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\ --- SongfolderPath
        // C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Images\\ --- ImageFolderPath

        // <WMP Functions>

        // 1. Creating instance of WMP control - WindowsMediaPlayer player = new WindowsMediaPlayer();
        // 2. Setting the URL of the media file that will be played - player.URL = "C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Songz\\";
        // 3. Start playing the media file - player.controls.play();
        // 4. Pausing the playback - player.controls.pause();
        // 5. Stopping the playback - player.controls.stop();

        private void SongLength_Click(object sender, EventArgs e)
        {
            SongLength.Visible = true;

        }
                                                                                                                                                             // T A S K S 
        private void PreviousButton_Click(object sender, EventArgs e)                                                             // 1. Get the music player to proceed to next song when current song ends.
        {                                                                                                                         // 2. Get the progress bar to show the song length.
            if (currentIndex > 0)                                                                                                 // 3. Get the mediaPlayer to cycle through the songs in the "songz", without the need to include the song path.
            {

                currentIndex--;

            }
            else
            {
                currentIndex = playlist.Length - 1;
            }


            SongText.Text = Path.GetFileNameWithoutExtension(playlist[currentIndex]);
            SongArt.Image = Image.FromFile("C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Images\\Music Note.png");

            mediaPlayer.URL = (playlist[currentIndex]);
            mediaPlayer.controls.play();
        }

        private void NextButton_Click(object sender, EventArgs e)  // Need to get the NextButton to stop the current song when moving to the next one. (Done)
        {
            if (currentIndex < playlist.Length - 1)
            {
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
            }


            string songPath = playlist[currentIndex];
            SongText.Text = Path.GetFileNameWithoutExtension(playlist[currentIndex]);
            SongArt.Image = Image.FromFile("C:\\Users\\warre\\source\\repos\\MusicPlayer\\MusicPlayer\\Images\\Music Note.png");

            mediaPlayer.controls.next();
            mediaPlayer.URL = playlist[currentIndex];

        }

        private void SongText_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Updates the progress bar with the songs position.
            if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Calculates the progress percent
                double progress = (mediaPlayer.controls.currentPosition / mediaPlayer.currentMedia.duration) * 100;
                SongLength.Value = (int)progress;
            }
        }
    }
}
