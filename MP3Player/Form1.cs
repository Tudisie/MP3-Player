using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private Color _disabledColor, _enabledColor;
        private bool _firstTime = true; //ForeColor defect la butoanele disabled
        private bool _loadedAux = false;
        private int _loadingSong; //unele operatii nu pot fi facute pana nu se incarca melodia in celalalt thread
        private double _progressBarTime;

        public mp3Form()
        {
            MessageBox.Show("Atentie!\nCa sa functioneze muzica:\n Decomentati:\n  -cele 2 linii din if (!_loadedAux)\n  -cele 2 linii din Song.cs/Play\n\n\tTudisie");

            InitializeComponent();
            _currentSong = new MP3Player.Song();

            if(loadPlaylists() == false)
            {
                _playlists.Add(new MP3Player.ConcretePlaylist("All songs"));    // playlist default
                listBoxPlaylists.Items.Add(_playlists[0].PlaylistName);
                listBoxPlaylists.SelectedIndex = 0;
            }
            _progressBarTime = 0.0;

            _disabledColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            _enabledColor = Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
        }

        private bool loadPlaylists()
        {
            _playlists = new List<Playlist>();

            try
            {

                string[] lines = System.IO.File.ReadAllLines("Playlists.txt");

                int numberOfPlaylists = 0;
                foreach(string line in lines)
                {
                    if(line[0] == '$') //Song
                    {
                        //Format: $song_name///song_path
                        string[] subs = line.Substring(1).Split(new String[] {"///"}, StringSplitOptions.None);
                        _playlists[numberOfPlaylists - 1].AddSong(subs[0],subs[1]);
                    }
                    else //Playlist
                    {
                        ++numberOfPlaylists;
                        _playlists.Add(new MP3Player.ConcretePlaylist(line));
                    }
                }

                RefreshPlaylists();

                listBoxPlaylists.SelectedIndex = 0;

                return true;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void mp3Form_Load(object sender, EventArgs e)
        {
            this.songTitle.Text = "Empty player";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(_currentSong.SongPath == null)
                return;
            if (this.songState.Text == "Playing")
                return;
            if (!File.Exists(_currentSong.SongPath))
            {
                _playlists[0].RemoveSong(_currentSong.SongName);
                NotifyPlaylists(_currentSong.SongName);

                RefreshSongs();

                if (listBoxSongs.Items.Count > 0)
                    listBoxSongs.SelectedIndex = 0;

                MessageBox.Show("File " + _currentSong.SongName + " doesn't exist in local PC.");
                return;
            }

            
            this.songTitle.Text = _currentSong.SongName;
            

            this.songState.Text = "Playing";
      

            _loadingSong = 10;
            _loadedAux = false;

            this.timerSong.Start();
            _currentSong.Play();
        }

        private void timerSong_Tick(object sender, EventArgs e)
        {  

            if (!_loadedAux)
            {
                if (_loadingSong <= 0)
                {
                    _loadedAux = true;
                    //this.songTime.Text = _currentSong.Wplayer.currentMedia.durationString;
                    //_currentSong.Wplayer.settings.volume = volumeBar.Value;
                }
                _loadingSong--;
            }
            else
            {
                this._currentSong.Update();
                int totalSeconds = this._currentSong.PassedTime / 70;
                string mins, secs;
                if (totalSeconds / 60 < 10)
                    mins = "0" + totalSeconds / 60;
                else
                    mins = "" + totalSeconds / 60;

                if (totalSeconds % 60 < 10)
                    secs = "0" + totalSeconds % 60;
                else
                    secs = "" + totalSeconds % 60;

                songPassedTime.Text = mins + ":" + secs;

                double rate = 0.2;
                _progressBarTime += rate;
                this.progressBarSong.Increment(Convert.ToInt32(_progressBarTime));
                _progressBarTime = _progressBarTime - Convert.ToInt32(_progressBarTime); // partea fractionara a lui rate
            }
            
            
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (_currentSong.SongPath == null)
                return;

            this.songState.Text = "Paused";
            this.timerSong.Stop();
            _currentSong.Pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (_currentSong.SongPath == null)
                return;

            this.songTitle.Text = "MP3 Player";
            this.songState.Text = "Stopped";
            this.timerSong.Stop();
            this.progressBarSong.Value = 0;
            this.songTime.Text = "00:00";
            this.songPassedTime.Text = "00:00";
            _currentSong.PassedTime = 0;
            _currentSong.Stop();
        }

        private void nextSongButton_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex < listBoxSongs.Items.Count - 1)
                listBoxSongs.SelectedIndex++;
            stopButton_Click(sender, e);
            startButton_Click(sender, e);
        }

        private void previousSongButton_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex > 0)
                listBoxSongs.SelectedIndex--;
            stopButton_Click(sender, e);
            startButton_Click(sender, e);
        }

        // Subscribe
        private void buttonAddPlaylist_Click(object sender, EventArgs e)
        {
            string newPlaylistName = Interaction.InputBox("Dati numele noului playlist:", "New playlist", "", -1, -1);

            if (newPlaylistName == "")
                return;
            
            for(int i = 0; i< _playlists.Count; i++)
                if(_playlists[i].PlaylistName == newPlaylistName)
                {
                    MessageBox.Show("Acest playlist exista deja.");
                    return;
                }

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

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            listBoxSongs.SelectedIndex = r.Next(listBoxSongs.Items.Count);

            stopButton_Click(sender, e);
            startButton_Click(sender, e);
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
                    // Se adauga by default in All Songs (playlist-ul 0)
                    _playlists[0].AddSong(name, ofd.FileName);

                    // Introducem denumirea in listbox-ul din interfata
                    RefreshPlaylists();

                    // By default, the selected song is the last added one
                    _currentSong.SongPath = path;
                    _currentSong.SongName = name;

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
            _currentSong.SongName = songName;
        }

        private void listBoxPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Afisam melodiile din playlist-ul selectat in fereastra din dreapta (cea cu melodii)

           
            RefreshSongs();
            if(listBoxSongs.Items.Count > 0)
                listBoxSongs.SelectedIndex = 0;

            if (_firstTime)
            {
                _firstTime = false;
                return;
            }

            if (listBoxPlaylists.SelectedIndex > 0 || listBoxSongs.Items.Count == 0 )
            {
                roundButtonAddSongToPlaylist.Enabled = false;
                roundButtonAddSongToPlaylist.BackColor = _disabledColor;
            }
            else
            {
                roundButtonAddSongToPlaylist.Enabled = true;
                roundButtonAddSongToPlaylist.BackColor = _enabledColor;
            }
        }

        private void powerOffButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Playlists.txt", "");
            for (int i = 0; i < _playlists.Count; i++)
            {
                File.AppendAllText("Playlists.txt", _playlists[i].PlaylistName + "\n");
                foreach(string str in _playlists[i].SongsWithPaths)
                {
                    //melodiile vor avea $ in fata pentru a le diferentia de playlisturi
                    File.AppendAllText("Playlists.txt", "$" + str + "\n");
                }
            }
            this.Close();
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            if (songState.Text == "Playing")
                _currentSong.Wplayer.settings.volume = volumeBar.Value;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MP3 Player Help.chm");
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            string text = "MP3 Player este un program cu ajutorul caruia se poate asculta muzica." +
                "Melodiile pot fi adaugate direct in playlist-ul general \"All Songs\" " + 
                "si dupa mutate in alte playlist-uri.";
            string title = "About MP3 Player";
            MessageBox.Show(text, title);
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
