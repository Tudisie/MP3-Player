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
            this.groupBoxControlPanel = new System.Windows.Forms.GroupBox();
            this.groupBoxPlaylists = new System.Windows.Forms.GroupBox();
            this.groupBoxSongs = new System.Windows.Forms.GroupBox();
            this.listBoxPlaylists = new System.Windows.Forms.ListBox();
            this.buttonAddPlaylist = new System.Windows.Forms.Button();
            this.buttonRemovePlaylist = new System.Windows.Forms.Button();
            this.roundButtonRemoveSong = new MP3Player.RoundButton();
            this.roundButtonAddSong = new MP3Player.RoundButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBoxPlaylists.SuspendLayout();
            this.groupBoxSongs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxControlPanel
            // 
            this.groupBoxControlPanel.Location = new System.Drawing.Point(12, 34);
            this.groupBoxControlPanel.Name = "groupBoxControlPanel";
            this.groupBoxControlPanel.Size = new System.Drawing.Size(479, 223);
            this.groupBoxControlPanel.TabIndex = 0;
            this.groupBoxControlPanel.TabStop = false;
            this.groupBoxControlPanel.Text = "Control Panel";
            // 
            // groupBoxPlaylists
            // 
            this.groupBoxPlaylists.Controls.Add(this.buttonRemovePlaylist);
            this.groupBoxPlaylists.Controls.Add(this.buttonAddPlaylist);
            this.groupBoxPlaylists.Controls.Add(this.listBoxPlaylists);
            this.groupBoxPlaylists.Location = new System.Drawing.Point(12, 284);
            this.groupBoxPlaylists.Name = "groupBoxPlaylists";
            this.groupBoxPlaylists.Size = new System.Drawing.Size(479, 232);
            this.groupBoxPlaylists.TabIndex = 1;
            this.groupBoxPlaylists.TabStop = false;
            this.groupBoxPlaylists.Text = "Playlists";
            // 
            // groupBoxSongs
            // 
            this.groupBoxSongs.Controls.Add(this.listBox2);
            this.groupBoxSongs.Controls.Add(this.roundButtonAddSong);
            this.groupBoxSongs.Controls.Add(this.roundButtonRemoveSong);
            this.groupBoxSongs.Location = new System.Drawing.Point(518, 34);
            this.groupBoxSongs.Name = "groupBoxSongs";
            this.groupBoxSongs.Size = new System.Drawing.Size(441, 482);
            this.groupBoxSongs.TabIndex = 2;
            this.groupBoxSongs.TabStop = false;
            this.groupBoxSongs.Text = "Songs";
            // 
            // listBoxPlaylists
            // 
            this.listBoxPlaylists.BackColor = System.Drawing.Color.Black;
            this.listBoxPlaylists.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxPlaylists.FormattingEnabled = true;
            this.listBoxPlaylists.ItemHeight = 16;
            this.listBoxPlaylists.Location = new System.Drawing.Point(16, 30);
            this.listBoxPlaylists.Name = "listBoxPlaylists";
            this.listBoxPlaylists.Size = new System.Drawing.Size(338, 180);
            this.listBoxPlaylists.TabIndex = 0;
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
            // roundButtonRemoveSong
            // 
            this.roundButtonRemoveSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.roundButtonRemoveSong.Location = new System.Drawing.Point(53, 437);
            this.roundButtonRemoveSong.Margin = new System.Windows.Forms.Padding(0);
            this.roundButtonRemoveSong.Name = "roundButtonRemoveSong";
            this.roundButtonRemoveSong.Size = new System.Drawing.Size(28, 28);
            this.roundButtonRemoveSong.TabIndex = 8;
            this.roundButtonRemoveSong.Text = "-";
            this.roundButtonRemoveSong.UseVisualStyleBackColor = false;
            // 
            // roundButtonAddSong
            // 
            this.roundButtonAddSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.roundButtonAddSong.Location = new System.Drawing.Point(19, 437);
            this.roundButtonAddSong.Margin = new System.Windows.Forms.Padding(0);
            this.roundButtonAddSong.Name = "roundButtonAddSong";
            this.roundButtonAddSong.Size = new System.Drawing.Size(28, 28);
            this.roundButtonAddSong.TabIndex = 9;
            this.roundButtonAddSong.Text = "+";
            this.roundButtonAddSong.UseVisualStyleBackColor = false;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Black;
            this.listBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(19, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(404, 404);
            this.listBox2.TabIndex = 10;
            // 
            // mp3Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.groupBoxSongs);
            this.Controls.Add(this.groupBoxPlaylists);
            this.Controls.Add(this.groupBoxControlPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "mp3Form";
            this.Text = "MP3 Player";
            this.groupBoxPlaylists.ResumeLayout(false);
            this.groupBoxSongs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControlPanel;
        private System.Windows.Forms.GroupBox groupBoxPlaylists;
        private System.Windows.Forms.GroupBox groupBoxSongs;
        private System.Windows.Forms.Button buttonRemovePlaylist;
        private System.Windows.Forms.Button buttonAddPlaylist;
        private System.Windows.Forms.ListBox listBoxPlaylists;
        private System.Windows.Forms.ListBox listBox2;
        private RoundButton roundButtonAddSong;
        private RoundButton roundButtonRemoveSong;
    }
}

