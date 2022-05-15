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
        private string _songName;
        private int _passedTime;

        public void Play()
        {
            try
            {
                if (_myThread == null)
                {
                    //_myThread = new Thread(PlaySong);
                    //_myThread.Start();

                    //Task.Run(() => PlaySong());
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
            _passedTime = 0;

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

        public string GetSongDuration()
        {
            int x;
            return _wplayer.currentMedia.durationString;
        }

        public void Update()
        {
            _passedTime += 1;
        }

        public string SongPath
        {
            get { return _songPath; }
            set { _songPath = value; }
        }

        public string SongName
        {
            get { return _songName; }
            set { _songName = value; }
        }

        public int PassedTime
        {
            get { return _passedTime; }
            set { _passedTime = value; }
        }

        public WindowsMediaPlayer Wplayer
        {
            get { return _wplayer; }
        }
    }
}
