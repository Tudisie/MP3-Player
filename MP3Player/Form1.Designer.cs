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
            this.groupBoxControlPanel = new System.Windows.Forms.GroupBox();
            this.progressBarSong = new MP3Player.NewProgressBar();
            this.songInfo = new System.Windows.Forms.RichTextBox();
            this.pauseButton = new MP3Player.RoundButton();
            this.previousSongButton = new MP3Player.RoundButton();
            this.nextSongButton = new MP3Player.RoundButton();
            this.stopButton = new MP3Player.RoundButton();
            this.playButton = new MP3Player.RoundButton();
            this.groupBoxPlaylists = new System.Windows.Forms.GroupBox();
            this.buttonRemovePlaylist = new System.Windows.Forms.Button();
            this.buttonAddPlaylist = new System.Windows.Forms.Button();
            this.listBoxPlaylists = new System.Windows.Forms.ListBox();
            this.groupBoxSongs = new System.Windows.Forms.GroupBox();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.roundButtonAddSong = new MP3Player.RoundButton();
            this.roundButtonRemoveSong = new MP3Player.RoundButton();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.timerSong = new System.Windows.Forms.Timer(this.components);
            this.groupBoxControlPanel.SuspendLayout();
            this.groupBoxPlaylists.SuspendLayout();
            this.groupBoxSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxControlPanel
            // 
            this.groupBoxControlPanel.Controls.Add(this.progressBarSong);
            this.groupBoxControlPanel.Controls.Add(this.songInfo);
            this.groupBoxControlPanel.Controls.Add(this.pauseButton);
            this.groupBoxControlPanel.Controls.Add(this.previousSongButton);
            this.groupBoxControlPanel.Controls.Add(this.nextSongButton);
            this.groupBoxControlPanel.Controls.Add(this.stopButton);
            this.groupBoxControlPanel.Controls.Add(this.playButton);
            this.groupBoxControlPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxControlPanel.Location = new System.Drawing.Point(12, 34);
            this.groupBoxControlPanel.Name = "groupBoxControlPanel";
            this.groupBoxControlPanel.Size = new System.Drawing.Size(479, 223);
            this.groupBoxControlPanel.TabIndex = 0;
            this.groupBoxControlPanel.TabStop = false;
            this.groupBoxControlPanel.Text = "Control Panel";
            this.groupBoxControlPanel.Enter += new System.EventHandler(this.groupBoxControlPanel_Enter);
            // 
            // progressBarSong
            // 
            this.progressBarSong.ForeColor = System.Drawing.Color.Fuchsia;
            this.progressBarSong.Location = new System.Drawing.Point(16, 120);
            this.progressBarSong.Name = "progressBarSong";
            this.progressBarSong.Size = new System.Drawing.Size(338, 10);
            this.progressBarSong.TabIndex = 18;
            // 
            // songInfo
            // 
            this.songInfo.BackColor = System.Drawing.SystemColors.MenuText;
            this.songInfo.ForeColor = System.Drawing.Color.White;
            this.songInfo.Location = new System.Drawing.Point(16, 30);
            this.songInfo.Name = "songInfo";
            this.songInfo.Size = new System.Drawing.Size(338, 68);
            this.songInfo.TabIndex = 17;
            this.songInfo.Text = "";
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Location = new System.Drawing.Point(102, 158);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(0);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(36, 36);
            this.pauseButton.TabIndex = 14;
            this.pauseButton.Text = "P";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // previousSongButton
            // 
            this.previousSongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.previousSongButton.FlatAppearance.BorderSize = 0;
            this.previousSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousSongButton.Location = new System.Drawing.Point(51, 158);
            this.previousSongButton.Margin = new System.Windows.Forms.Padding(0);
            this.previousSongButton.Name = "previousSongButton";
            this.previousSongButton.Size = new System.Drawing.Size(36, 36);
            this.previousSongButton.TabIndex = 13;
            this.previousSongButton.Text = "<";
            this.previousSongButton.UseVisualStyleBackColor = false;
            // 
            // nextSongButton
            // 
            this.nextSongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.nextSongButton.FlatAppearance.BorderSize = 0;
            this.nextSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextSongButton.Location = new System.Drawing.Point(288, 158);
            this.nextSongButton.Margin = new System.Windows.Forms.Padding(0);
            this.nextSongButton.Name = "nextSongButton";
            this.nextSongButton.Size = new System.Drawing.Size(36, 36);
            this.nextSongButton.TabIndex = 12;
            this.nextSongButton.Text = ">";
            this.nextSongButton.UseVisualStyleBackColor = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(237, 158);
            this.stopButton.Margin = new System.Windows.Forms.Padding(0);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(36, 36);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "S";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(156, 144);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(64, 64);
            this.playButton.TabIndex = 10;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBoxPlaylists
            // 
            this.groupBoxPlaylists.Controls.Add(this.buttonRemovePlaylist);
            this.groupBoxPlaylists.Controls.Add(this.buttonAddPlaylist);
            this.groupBoxPlaylists.Controls.Add(this.listBoxPlaylists);
            this.groupBoxPlaylists.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxPlaylists.Location = new System.Drawing.Point(12, 284);
            this.groupBoxPlaylists.Name = "groupBoxPlaylists";
            this.groupBoxPlaylists.Size = new System.Drawing.Size(479, 232);
            this.groupBoxPlaylists.TabIndex = 1;
            this.groupBoxPlaylists.TabStop = false;
            this.groupBoxPlaylists.Text = "Playlists";
            // 
            // buttonRemovePlaylist
            // 
            this.buttonRemovePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.buttonRemovePlaylist.Location = new System.Drawing.Point(359, 171);
            this.buttonRemovePlaylist.Name = "buttonRemovePlaylist";
            this.buttonRemovePlaylist.Size = new System.Drawing.Size(115, 40);
            this.buttonRemovePlaylist.TabIndex = 2;
            this.buttonRemovePlaylist.Text = "Remove playlist";
            this.buttonRemovePlaylist.UseVisualStyleBackColor = false;
            // 
            // buttonAddPlaylist
            // 
            this.buttonAddPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.buttonAddPlaylist.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAddPlaylist.Location = new System.Drawing.Point(359, 126);
            this.buttonAddPlaylist.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAddPlaylist.Name = "buttonAddPlaylist";
            this.buttonAddPlaylist.Size = new System.Drawing.Size(115, 40);
            this.buttonAddPlaylist.TabIndex = 1;
            this.buttonAddPlaylist.Text = "Add playlist";
            this.buttonAddPlaylist.UseVisualStyleBackColor = false;
            // 
            // listBoxPlaylists
            // 
            this.listBoxPlaylists.BackColor = System.Drawing.Color.Black;
            this.listBoxPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylists.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxPlaylists.FormattingEnabled = true;
            this.listBoxPlaylists.ItemHeight = 16;
            this.listBoxPlaylists.Location = new System.Drawing.Point(16, 30);
            this.listBoxPlaylists.Name = "listBoxPlaylists";
            this.listBoxPlaylists.Size = new System.Drawing.Size(338, 176);
            this.listBoxPlaylists.TabIndex = 0;
            // 
            // groupBoxSongs
            // 
            this.groupBoxSongs.Controls.Add(this.listBoxSongs);
            this.groupBoxSongs.Controls.Add(this.roundButtonAddSong);
            this.groupBoxSongs.Controls.Add(this.roundButtonRemoveSong);
            this.groupBoxSongs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSongs.Location = new System.Drawing.Point(518, 34);
            this.groupBoxSongs.Name = "groupBoxSongs";
            this.groupBoxSongs.Size = new System.Drawing.Size(441, 482);
            this.groupBoxSongs.TabIndex = 2;
            this.groupBoxSongs.TabStop = false;
            this.groupBoxSongs.Text = "Songs";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BackColor = System.Drawing.Color.Black;
            this.listBoxSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSongs.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 16;
            this.listBoxSongs.Location = new System.Drawing.Point(19, 30);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(404, 400);
            this.listBoxSongs.TabIndex = 10;
            // 
            // roundButtonAddSong
            // 
            this.roundButtonAddSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.roundButtonAddSong.FlatAppearance.BorderSize = 0;
            this.roundButtonAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonAddSong.Location = new System.Drawing.Point(19, 437);
            this.roundButtonAddSong.Margin = new System.Windows.Forms.Padding(0);
            this.roundButtonAddSong.Name = "roundButtonAddSong";
            this.roundButtonAddSong.Size = new System.Drawing.Size(32, 32);
            this.roundButtonAddSong.TabIndex = 9;
            this.roundButtonAddSong.Text = "+";
            this.roundButtonAddSong.UseVisualStyleBackColor = false;
            // 
            // roundButtonRemoveSong
            // 
            this.roundButtonRemoveSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.roundButtonRemoveSong.FlatAppearance.BorderSize = 0;
            this.roundButtonRemoveSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonRemoveSong.Location = new System.Drawing.Point(62, 437);
            this.roundButtonRemoveSong.Margin = new System.Windows.Forms.Padding(0);
            this.roundButtonRemoveSong.Name = "roundButtonRemoveSong";
            this.roundButtonRemoveSong.Size = new System.Drawing.Size(32, 32);
            this.roundButtonRemoveSong.TabIndex = 8;
            this.roundButtonRemoveSong.Text = "-";
            this.roundButtonRemoveSong.UseVisualStyleBackColor = false;
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(429, 55);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBar.Size = new System.Drawing.Size(56, 187);
            this.volumeBar.TabIndex = 18;
            this.volumeBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timerSong
            // 
            this.timerSong.Interval = 10;
            this.timerSong.Tick += new System.EventHandler(this.timerSong_Tick);
            // 
            // mp3Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.groupBoxSongs);
            this.Controls.Add(this.groupBoxPlaylists);
            this.Controls.Add(this.groupBoxControlPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "mp3Form";
            this.Text = "MP3 Player";
            this.Load += new System.EventHandler(this.mp3Form_Load);
            this.groupBoxControlPanel.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox songInfo;
        private System.Windows.Forms.TrackBar volumeBar;
        private NewProgressBar progressBarSong;
        private System.Windows.Forms.Timer timerSong;
    }
}

