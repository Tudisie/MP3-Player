using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player
{
    public class Playlist
    {
        // Numele playlistului
        string _playlistName;

        // Fiecare playlist are o lista de melodii
        private Dictionary<string, string> _songList;

        public Playlist()
        {
            _playlistName = "Noname";
            _songList = new Dictionary<string, string>();
        }

        public Playlist(string playlistName)
        {
            _playlistName = playlistName;
            _songList = new Dictionary<string, string>();
        }

        public string[] Songs
        {
            get
            {
                string[] songs = new string[_songList.Count];
                int i = 0;
                foreach(KeyValuePair<string, string> elem in _songList)
                {
                    songs[i++] = elem.Key;
                }

                return songs;
            }
        }

        public string PlaylistSongPath(string name)
        {
            return _songList[name];
        }

        public string PlaylistName
        {
            get { return _playlistName; }
        }

        public void AddSong(string name, string path)
        {
            _songList[name] = path;
        }

        public void RemoveSong(string name)
        {
            _songList.Remove(name);
        }

    }
}
