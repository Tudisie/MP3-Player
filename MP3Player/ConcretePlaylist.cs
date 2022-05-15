using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player
{
    // Concrete subscriber
    public class ConcretePlaylist : Playlist
    {
        public ConcretePlaylist()
        {
            _playlistName = "Noname";
            _songList = new Dictionary<string, string>();
        }

        public ConcretePlaylist(string playlistName)
        {
            _playlistName = playlistName;
            _songList = new Dictionary<string, string>();
        }

        public override string[] Songs
        {
            get
            {
                string[] songs = new string[_songList.Count];
                int i = 0;
                foreach (KeyValuePair<string, string> elem in _songList)
                {
                    songs[i++] = elem.Key;
                }

                return songs;
            }
        }

        public override string[] SongsWithPaths
        {
            get
            {
                string[] songs = new string[_songList.Count];
                int i = 0;
                foreach (KeyValuePair<string, string> elem in _songList)
                {
                    songs[i++] = elem.Key + "///" + elem.Value;
                }

                return songs;
            }
        }

        public override string PlaylistName
        {
            get { return _playlistName; }
        }

        public override string PlaylistSongPath(string name)
        {
            return _songList[name];
        }

        public override void AddSong(string name, string path)
        {
            _songList[name] = path;
        }

        public override void RemoveSong(string name)
        {
            _songList.Remove(name);
        }

        // Update
        public override void Update(string songName)
        {
            if (_songList.ContainsKey(songName))
                RemoveSong(songName);
        }
    }
}
