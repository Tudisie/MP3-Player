using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MP3Player
{
    public class Song
    {
        private WindowsMediaPlayer _wplayer = null;
        private Thread _myThread;
        private bool _isPaused = false;
        private string _songPath;

        public void Play()
        {
            try
            {
                if (_myThread == null)
                {
                    _myThread = new Thread(PlaySong);
                    _myThread.Start();
                    _isPaused = false;
                }
                else
                {
                    if (_isPaused)
                    {
                        _wplayer.controls.play();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PlaySong()
        {
            _wplayer = new WindowsMediaPlayer();
            _wplayer.URL = _songPath;
            _wplayer.controls.play();
        }

        public void Pause()
        {
            if (_wplayer != null)
            {
                _wplayer.controls.pause();
                _isPaused = true;
            }
        }

        public void Stop()
        {
            if (_wplayer != null)
            {
                _wplayer.controls.stop();
                _myThread.Abort();
                _myThread = null;
            }
        }

        public string SongPath
        {
            set { _songPath = value; }
        }

    }
}
