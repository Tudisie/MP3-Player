using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player
{
    // Subscriber
    public abstract class Playlist
    {
        // Numele playlistului
        protected string _playlistName;

        // Fiecare playlist are o lista de melodii
        protected Dictionary<string, string> _songList;

        public abstract string[] Songs
        {
            get;
        }

        public abstract string[] SongsWithPaths
        {
            get;
        }

        public abstract string PlaylistName
        {
            get;
        }

        public abstract string PlaylistSongPath(string name);

        public abstract void AddSong(string name, string path);

        public abstract void RemoveSong(string name);

        // Update
        public abstract void Update(string songName);

    }
}
