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
            this.songInfo.Text = "First song";
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
    }
}
