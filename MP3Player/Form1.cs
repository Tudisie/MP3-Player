using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3Player
{
    public partial class mp3Form : Form
    {
        public mp3Form()
        {
            InitializeComponent();
        }

        private void groupBoxControlPanel_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mp3Form_Load(object sender, EventArgs e)
        {
            this.songTitle.Text = "Empty player";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.timerSong.Start();
        }

        private void timerSong_Tick(object sender, EventArgs e)
        {
            this.progressBarSong.Increment(1);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.timerSong.Stop();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.timerSong.Stop();
            this.progressBarSong.Value = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                    MessageBox.Show(ofd.FileName);
                    //Song mp3 = Song.Instance();
                    //mp3.open(ofd.FileName);
                    //mp3.play();
                }
            }
        }
    }
}
