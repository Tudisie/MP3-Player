namespace MP3Player
{
    partial class mp3Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox songLogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mp3Form));
            this.groupBoxControlPanel = new System.Windows.Forms.GroupBox();
            this.progressBarSong = new MP3Player.NewProgressBar();
            this.songDisplay = new System.Windows.Forms.Panel();
            this.songType = new System.Windows.Forms.Label();
            this.songState = new System.Windows.Forms.Label();
            this.songPassedTime = new System.Windows.Forms.Label();
            this.songTitle = new System.Windows.Forms.Label();
            this.playButton = new MP3Player.RoundButton();
            this.pauseButton = new MP3Player.RoundButton();
            this.previousSongButton = new MP3Player.RoundButton();
            this.nextSongButton = new MP3Player.RoundButton();
            this.stopButton = new MP3Player.RoundButton();
            this.groupBoxPlaylists = new System.Windows.Forms.GroupBox();
            this.buttonRemovePlaylist = new System.Windows.Forms.Button();
            this.buttonAddPlaylist = new System.Windows.Forms.Button();
            this.listBoxPlaylists = new System.Windows.Forms.ListBox();
            this.groupBoxSongs = new System.Windows.Forms.GroupBox();
            this.roundButtonAddSongToPlaylist = new MP3Player.RoundButton();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.roundButtonAddSong = new MP3Player.RoundButton();
            this.roundButtonRemoveSong = new MP3Player.RoundButton();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.timerSong = new System.Windows.Forms.Timer(this.components);
            this.powerOffButton = new MP3Player.RoundButton();
            songLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(songLogo)).BeginInit();
            this.groupBoxControlPanel.SuspendLayout();
            this.songDisplay.SuspendLayout();
            this.groupBoxPlaylists.SuspendLayout();
            this.groupBoxSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // songLogo
            // 
            songLogo.Image = ((System.Drawing.Image)(resources.GetObject("songLogo.Image")));
            songLogo.Location = new System.Drawing.Point(13, 7);
            songLogo.Name = "songLogo";
            songLogo.Size = new System.Drawing.Size(58, 63);
            songLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            songLogo.TabIndex = 1;
            songLogo.TabStop = false;
            // 
            // groupBoxControlPanel
            // 
            this.groupBoxControlPanel.Controls.Add(this.progressBarSong);
            this.groupBoxControlPanel.Controls.Add(this.songDisplay);
            this.groupBoxControlPanel.Controls.Add(this.playButton);
            this.groupBoxControlPanel.Controls.Add(this.pauseButton);
            this.groupBoxControlPanel.Controls.Add(this.previousSongButton);
            this.groupBoxControlPanel.Controls.Add(this.nextSongButton);
            this.groupBoxControlPanel.Controls.Add(this.stopButton);
            this.groupBoxControlPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxControlPanel.Location = new System.Drawing.Point(12, 34);
            this.groupBoxControlPanel.Name = "groupBoxControlPanel";
            this.groupBoxControlPanel.Size = new System.Drawing.Size(479, 223);
            this.groupBoxControlPanel.TabIndex = 0;
            this.groupBoxControlPanel.TabStop = false;
            this.groupBoxControlPanel.Text = "Control Panel";
            // 
            // progressBarSong
            // 
            this.progressBarSong.Location = new System.Drawing.Point(16, 120);
            this.progressBarSong.Name = "progressBarSong";
            this.progressBarSong.Size = new System.Drawing.Size(338, 10);
            this.progressBarSong.TabIndex = 20;
            // 
            // songDisplay
            // 
            this.songDisplay.BackColor = System.Drawing.Color.Black;
            this.songDisplay.Controls.Add(this.songType);
            this.songDisplay.Controls.Add(this.songState);
            this.songDisplay.Controls.Add(this.songPassedTime);
            this.songDisplay.Controls.Add(songLogo);
            this.songDisplay.Controls.Add(this.songTitle);
            this.songDisplay.Location = new System.Drawing.Point(16, 22);
            this.songDisplay.Name = "songDisplay";
            this.songDisplay.Size = new System.Drawing.Size(338, 73);
            this.songDisplay.TabIndex = 19;
            // 
            // songType
            // 
            this.songType.AutoSize = true;
            this.songType.Location = new System.Drawing.Point(158, 55);
            this.songType.Name = "songType";
            this.songType.Size = new System.Drawing.Size(36, 17);
            this.songType.TabIndex = 5;
            this.songType.Text = "MP3";
            // 
            // songState
            // 
            this.songState.AutoSize = true;
            this.songState.Location = new System.Drawing.Point(87, 53);
            this.songState.Name = "songState";
            this.songState.Size = new System.Drawing.Size(57, 17);
            this.songState.TabIndex = 4;
            this.songState.Text = "Starting";
            // 
            // songPassedTime
            // 
            this.songPassedTime.AutoSize = true;
            this.songPassedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songPassedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.songPassedTime.Location = new System.Drawing.Point(268, 53);
            this.songPassedTime.Name = "songPassedTime";
            this.songPassedTime.Size = new System.Drawing.Size(55, 24);
            this.songPassedTime.TabIndex = 2;
            this.songPassedTime.Text = "00:00";
            // 
            // songTitle
            // 
            this.songTitle.AutoSize = true;
            this.songTitle.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTitle.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.songTitle.Location = new System.Drawing.Point(77, 7);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(136, 53);
            this.songTitle.TabIndex = 0;
            this.songTitle.Text = "Welcome!";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playButton.Location = new System.Drawing.Point(155, 144);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(64, 64);
            this.playButton.TabIndex = 10;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Location = new System.Drawing.Point(102, 158);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(0);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(36, 36);
            this.pauseButton.TabIndex = 14;
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // previousSongButton
            // 
            this.previousSongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.previousSongButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousSongButton.BackgroundImage")));
            this.previousSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousSongButton.FlatAppearance.BorderSize = 0;
            this.previousSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousSongButton.Location = new System.Drawing.Point(51, 158);
            this.previousSongButton.Margin = new System.Windows.Forms.Padding(0);
            this.previousSongButton.Name = "previousSongButton";
            this.previousSongButton.Size = new System.Drawing.Size(36, 36);
            this.previousSongButton.TabIndex = 13;
            this.previousSongButton.UseVisualStyleBackColor = false;
            // 
            // nextSongButton
            // 
            this.nextSongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.nextSongButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextSongButton.BackgroundImage")));
            this.nextSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextSongButton.FlatAppearance.BorderSize = 0;
            this.nextSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextSongButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nextSongButton.Location = new System.Drawing.Point(288, 158);
            this.nextSongButton.Margin = new System.Windows.Forms.Padding(0);
            this.nextSongButton.Name = "nextSongButton";
            this.nextSongButton.Size = new System.Drawing.Size(36, 36);
            this.nextSongButton.TabIndex = 12;
            this.nextSongButton.UseVisualStyleBackColor = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(237, 158);
            this.stopButton.Margin = new System.Windows.Forms.Padding(0);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(36, 36);
            this.stopButton.TabIndex = 11;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // groupBoxPlaylists
            // 
            this.groupBoxPlaylists.Controls.Add(this.buttonRemovePlaylist);
            this.groupBoxPlaylists.Controls.Add(this.buttonAddPlaylist);
            this.groupBoxPlaylists.Controls.Add(this.listBoxPlaylists);
            this.groupBoxPlaylists.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxPlaylists.Location = new System.Drawing.Point(12, 284);
            this.groupBoxPlaylists.Name = "groupBoxPlaylists";
            this.groupBoxPlaylists.Size = new System.Drawing.Size(479, 219);
            this.groupBoxPlaylists.TabIndex = 1;
            this.groupBoxPlaylists.TabStop = false;
            this.groupBoxPlaylists.Text = "Playlists";
            // 
            // buttonRemovePlaylist
            // 
            this.buttonRemovePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.buttonRemovePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemovePlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.buttonRemovePlaylist.Location = new System.Drawing.Point(359, 150);
            this.buttonRemovePlaylist.Name = "buttonRemovePlaylist";
            this.buttonRemovePlaylist.Size = new System.Drawing.Size(114, 51);
            this.buttonRemovePlaylist.TabIndex = 2;
            this.buttonRemovePlaylist.Text = "Remove playlist";
            this.buttonRemovePlaylist.UseVisualStyleBackColor = false;
            this.buttonRemovePlaylist.Click += new System.EventHandler(this.buttonRemovePlaylist_Click);
            // 
            // buttonAddPlaylist
            // 
            this.buttonAddPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.buttonAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.buttonAddPlaylist.Location = new System.Drawing.Point(359, 89);
            this.buttonAddPlaylist.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAddPlaylist.Name = "buttonAddPlaylist";
            this.buttonAddPlaylist.Size = new System.Drawing.Size(114, 48);
            this.buttonAddPlaylist.TabIndex = 1;
            this.buttonAddPlaylist.Text = "Add playlist";
            this.buttonAddPlaylist.UseVisualStyleBackColor = false;
            this.buttonAddPlaylist.Click += new System.EventHandler(this.buttonAddPlaylist_Click);
            // 
            // listBoxPlaylists
            // 
            this.listBoxPlaylists.BackColor = System.Drawing.Color.Black;
            this.listBoxPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlaylists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.listBoxPlaylists.FormattingEnabled = true;
            this.listBoxPlaylists.ItemHeight = 20;
            this.listBoxPlaylists.Location = new System.Drawing.Point(16, 30);
            this.listBoxPlaylists.Name = "listBoxPlaylists";
            this.listBoxPlaylists.Size = new System.Drawing.Size(338, 180);
            this.listBoxPlaylists.TabIndex = 0;
            this.listBoxPlaylists.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylists_SelectedIndexChanged);
            // 
            // groupBoxSongs
            // 
            this.groupBoxSongs.Controls.Add(this.roundButtonAddSongToPlaylist);
            this.groupBoxSongs.Controls.Add(this.listBoxSongs);
            this.groupBoxSongs.Controls.Add(this.roundButtonAddSong);
            this.groupBoxSongs.Controls.Add(this.roundButtonRemoveSong);
            this.groupBoxSongs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSongs.Location = new System.Drawing.Point(518, 34);
            this.groupBoxSongs.Name = "groupBoxSongs";
            this.groupBoxSongs.Size = new System.Drawing.Size(441, 469);
            this.groupBoxSongs.TabIndex = 2;
            this.groupBoxSongs.TabStop = false;
            this.groupBoxSongs.Text = "Songs";
            // 
            // roundButtonAddSongToPlaylist
            // 
            this.roundButtonAddSongToPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundButtonAddSongToPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonAddSongToPlaylist.BackgroundImage")));
            this.roundButtonAddSongToPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButtonAddSongToPlaylist.Enabled = false;
            this.roundButtonAddSongToPlaylist.FlatAppearance.BorderSize = 0;
            this.roundButtonAddSongToPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonAddSongToPlaylist.Location = new System.Drawing.Point(104, 419);
            this.roundButtonAddSongToPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.roundButtonAddSongToPlaylist.Name = "roundButtonAddSongToPlaylist";
            this.roundButtonAddSongToPlaylist.Size = new System.Drawing.Size(32, 32);
            this.roundButtonAddSongToPlaylist.TabIndex = 11;
            this.roundButtonAddSongToPlaylist.UseVisualStyleBackColor = false;
            this.roundButtonAddSongToPlaylist.Click += new System.EventHandler(this.roundButtonAddSongToPlaylist_Click);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BackColor = System.Drawing.Color.Black;
            this.listBoxSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 20;
            this.listBoxSongs.Location = new System.Drawing.Point(19, 30);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(404, 380);
            this.listBoxSongs.TabIndex = 10;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // roundButtonAddSong
            // 
            this.roundButtonAddSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.roundButtonAddSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonAddSong.BackgroundImage")));
            this.roundButtonAddSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButtonAddSong.FlatAppearance.BorderSize = 0;
            this.roundButtonAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonAddSong.Location = new System.Drawing.Point(19, 419);
            this.roundButtonAddSong.Margin = new System.Windows.Forms.Padding(0);
            this.roundButtonAddSong.Name = "roundButtonAddSong";
            this.roundButtonAddSong.Size = new System.Drawing.Size(32, 32);
            this.roundButtonAddSong.TabIndex = 9;
            this.roundButtonAddSong.UseVisualStyleBackColor = false;
            this.roundButtonAddSong.Click += new System.EventHandler(this.roundButtonAddSong_Click);
            // 
            // roundButtonRemoveSong
            // 
            this.roundButtonRemoveSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.roundButtonRemoveSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonRemoveSong.BackgroundImage")));
            this.roundButtonRemoveSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButtonRemoveSong.FlatAppearance.BorderSize = 0;
            this.roundButtonRemoveSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonRemoveSong.Location = new System.Drawing.Point(62, 419);
            this.roundButtonRemoveSong.Margin = new System.Windows.Forms.Padding(0);
            this.roundButtonRemoveSong.Name = "roundButtonRemoveSong";
            this.roundButtonRemoveSong.Size = new System.Drawing.Size(32, 32);
            this.roundButtonRemoveSong.TabIndex = 8;
            this.roundButtonRemoveSong.UseVisualStyleBackColor = false;
            this.roundButtonRemoveSong.Click += new System.EventHandler(this.roundButtonRemoveSong_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(429, 55);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBar.Size = new System.Drawing.Size(56, 187);
            this.volumeBar.TabIndex = 18;
            // 
            // timerSong
            // 
            this.timerSong.Interval = 10;
            this.timerSong.Tick += new System.EventHandler(this.timerSong_Tick);
            // 
            // powerOffButton
            // 
            this.powerOffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.powerOffButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("powerOffButton.BackgroundImage")));
            this.powerOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.powerOffButton.FlatAppearance.BorderSize = 0;
            this.powerOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerOffButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.powerOffButton.Location = new System.Drawing.Point(477, 518);
            this.powerOffButton.Margin = new System.Windows.Forms.Padding(0);
            this.powerOffButton.Name = "powerOffButton";
            this.powerOffButton.Size = new System.Drawing.Size(64, 64);
            this.powerOffButton.TabIndex = 19;
            this.powerOffButton.UseVisualStyleBackColor = false;
            this.powerOffButton.Click += new System.EventHandler(this.powerOffButton_Click);
            // 
            // mp3Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(982, 595);
            this.Controls.Add(this.powerOffButton);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.groupBoxSongs);
            this.Controls.Add(this.groupBoxPlaylists);
            this.Controls.Add(this.groupBoxControlPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "mp3Form";
            this.Text = "MP3 Player";
            this.Load += new System.EventHandler(this.mp3Form_Load);
            ((System.ComponentModel.ISupportInitialize)(songLogo)).EndInit();
            this.groupBoxControlPanel.ResumeLayout(false);
            this.songDisplay.ResumeLayout(false);
            this.songDisplay.PerformLayout();
            this.groupBoxPlaylists.ResumeLayout(false);
            this.groupBoxSongs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControlPanel;
        private System.Windows.Forms.GroupBox groupBoxPlaylists;
        private System.Windows.Forms.GroupBox groupBoxSongs;
        private System.Windows.Forms.Button buttonRemovePlaylist;
        private System.Windows.Forms.Button buttonAddPlaylist;
        private System.Windows.Forms.ListBox listBoxPlaylists;
        private System.Windows.Forms.ListBox listBoxSongs;
        private RoundButton roundButtonAddSong;
        private RoundButton roundButtonRemoveSong;
        private RoundButton playButton;
        private RoundButton pauseButton;
        private RoundButton previousSongButton;
        private RoundButton nextSongButton;
        private RoundButton stopButton;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Timer timerSong;
        private System.Windows.Forms.Panel songDisplay;
        private System.Windows.Forms.Label songTitle;
        private System.Windows.Forms.Label songPassedTime;
        private NewProgressBar progressBarSong;
        private System.Windows.Forms.Label songState;
        private System.Windows.Forms.Label songType;
        private RoundButton roundButtonAddSongToPlaylist;
        private RoundButton powerOffButton;
    }
}

