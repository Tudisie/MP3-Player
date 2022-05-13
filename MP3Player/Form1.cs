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

using Microsoft.VisualBasic;
using WMPLib;

namespace MP3Player
{
    // Clasa Publisher (in interfata grafica - form - se produc modificarile (se sterg melodii de ex))
    public partial class mp3Form : Form 
    {
        private Song _currentSong;
        // Subscriberi
        private List<Playlist> _playlists; 

        public mp3Form()
        {
            InitializeComponent();
            _currentSong = new MP3Player.Song();
            _playlists = new List<Playlist>();
            _playlists.Add(new MP3Player.ConcretePlaylist("All songs"));    // playlist default
            listBoxPlaylists.Items.Add(_playlists[0].PlaylistName);
            listBoxPlaylists.SelectedIndex = 0;
        }

        private void mp3Form_Load(object sender, EventArgs e)
        {
            this.songTitle.Text = "Empty player";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.timerSong.Start();
            _currentSong.Play();   
        }

        private void timerSong_Tick(object sender, EventArgs e)
        {
            this.progressBarSong.Increment(1);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.timerSong.Stop();
            _currentSong.Pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.timerSong.Stop();
            this.progressBarSong.Value = 0;
            _currentSong.Stop();
        }

        // Subscribe
        private void buttonAddPlaylist_Click(object sender, EventArgs e)
        {
            string newPlaylistName = Interaction.InputBox("Dati numele noului playlist:", "New playlist", "", -1, -1);
            _playlists.Add(new MP3Player.ConcretePlaylist(newPlaylistName));

            RefreshPlaylists();
        }

        // Unsubscribe
        private void buttonRemovePlaylist_Click(object sender, EventArgs e)
        {
            if(_playlists[listBoxPlaylists.SelectedIndex].PlaylistName != "All songs")
            {
                _playlists.RemoveAt(listBoxPlaylists.SelectedIndex);

                RefreshPlaylists();
            }
        }

        private void RefreshPlaylists()
        {
            listBoxPlaylists.Items.Clear();
            for(int i = 0; i < _playlists.Count; i++)
                listBoxPlaylists.Items.Add(_playlists[i].PlaylistName);

            listBoxPlaylists.SelectedIndex = 0;
        }

        private void roundButtonAddSong_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    char c = @"\".ToCharArray()[0];
                    string[] aux = ofd.FileName.Split(c);
                    string name = aux[aux.Length - 1];
                    string path = ofd.FileName;

                    // Cream o pereche <denumire, path> pt fiecare melodie adaugata
                    _playlists[0].AddSong(name, ofd.FileName);

                    // Introducem denumirea in listbox-ul din interfata
                    RefreshPlaylists();

                    // By default, the selected song is the last added one
                    _currentSong.SongPath = path;

                }
            }
        }

        private void roundButtonRemoveSong_Click(object sender, EventArgs e)
        {
            string songName = listBoxSongs.GetItemText(listBoxSongs.SelectedItem);
            _playlists[listBoxPlaylists.SelectedIndex].RemoveSong(songName);
            RefreshSongs();
            if(listBoxPlaylists.SelectedIndex == 0)
            {
                // Daca am sters melodia din playlistul default (cel care contine toate melodiile), 
                // atunci melodia respectiva trebuie stearsa si din toate celelalte playlisturi
                NotifyPlaylists(songName);
            }

            if (listBoxSongs.Items.Count > 0)
                listBoxSongs.SelectedIndex = 0;
            
        }

        // Notify subscribers
        private void NotifyPlaylists(string songName)
        {
            if(_playlists.Count > 1)
            {
                for (int i = 0; i < _playlists.Count; i++)
                    _playlists[i].Update(songName);
            }
        }

        private void RefreshSongs()
        {
            string[] songNames = _playlists[listBoxPlaylists.SelectedIndex].Songs;

            listBoxSongs.Items.Clear();
            for (int i = 0; i < songNames.Length; i++)
                listBoxSongs.Items.Add(songNames[i]);
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string songName = listBoxSongs.GetItemText(listBoxSongs.SelectedItem);
            _currentSong.SongPath = _playlists[listBoxPlaylists.SelectedIndex].PlaylistSongPath(songName);
        }

        private void listBoxPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Afisam melodiile din playlist-ul selectat in fereastra din dreapta (cea cu melodii)
            RefreshSongs();
            if(listBoxSongs.Items.Count > 0)
                listBoxSongs.SelectedIndex = 0;
        }

        private void roundButtonAddSongToPlaylist_Click(object sender, EventArgs e)
        {
            string playlistName = Interaction.InputBox("In ce playlist introduceti melodia?", "Add song to playlist", "", -1, -1);

            if (listBoxPlaylists.SelectedIndex == 0)
            {
                if (listBoxSongs.SelectedIndex != -1)
                {
                    // Daca am selectat o melodie
                    if (playlistName != "All songs")
                    {
                        // Daca playlistul in care dorim sa adaugam melodia nu este cel default (melodiile exista deja in playlistul default, nu are rost sa adaugam aici)

                        // Cautam indexul playlistului cu numele dat
                        int playlistIndex = -1;
                        for (int i = 1; i < _playlists.Count; i++)  // nu iteram si playlistul default
                        {
                            if (_playlists[i].PlaylistName == playlistName)
                            {
                                playlistIndex = i;
                                break;
                            }
                        }

                        if (playlistIndex != -1)
                        {
                            string songName = listBoxSongs.GetItemText(listBoxSongs.SelectedItem);
                            string songPath = _playlists[0].PlaylistSongPath(songName); // luam path-ul din playlist-ul default

                            _playlists[playlistIndex].AddSong(songName, songPath);
                            RefreshPlaylists();
                            if (listBoxSongs.Items.Count > 0)
                                listBoxSongs.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Playlistul in care doriti sa introduceti melodia nu exista!");
                        }
                    }
                }
                else
                {
                    // Nicio melodie nu este selectata
                    MessageBox.Show("Selectati o melodie din lista mai intai!");
                }
            }
            else
            {
                MessageBox.Show("Trebuie sa fiti in playlist-ul default pt a adauga melodii in alt playlist!");
            }
        }

       
    }
}
