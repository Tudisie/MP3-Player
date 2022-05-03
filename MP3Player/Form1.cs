using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MP3Player
{
    public partial class mp3Form : Form
    {
        private Song song;
        public mp3Form()
        {
            InitializeComponent();
            song = new MP3Player.Song();
        }

        private void mp3Form_Load(object sender, EventArgs e)
        {
            this.songTitle.Text = "Empty player";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.timerSong.Start();
            song.Play();   
        }

        private void timerSong_Tick(object sender, EventArgs e)
        {
            this.progressBarSong.Increment(1);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.timerSong.Stop();
            song.Pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.timerSong.Stop();
            this.progressBarSong.Value = 0;
            song.Stop();
        }

        private void buttonAddPlaylist_Click(object sender, EventArgs e)
        {
            this.listBoxPlaylists.Items.Add("ASD");
        }

        private void roundButtonAddSong_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    song.SongPath = ofd.FileName;
                }
            }
        }

    }
}
