using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player
{
    internal class Song
    {
        private static Song _instance;
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);

        private Song()
        {

        }
        public static Song Instance() //Singleton
        {
            if (_instance == null)
                _instance = new Song();
            return _instance;
        }
        public void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
        }

        public void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }
    }
}
