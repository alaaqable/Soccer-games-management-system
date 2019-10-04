namespace ProjectFinFormation1
{
    partial class PlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.FormPlayerTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClosePlayerForm = new System.Windows.Forms.Button();
            this.txtCIN = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtPosition = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtNumbre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Dtpplayer = new System.Windows.Forms.DateTimePicker();
            this.comboPlayerTeam = new System.Windows.Forms.ComboBox();
            this.ButtonAddPlayer = new System.Windows.Forms.Button();
            this.ButtonEditPlayer = new System.Windows.Forms.Button();
            this.bunifuDragControlPlayer = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.FormPlayerTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPlayerTopPanel
            // 
            this.FormPlayerTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.FormPlayerTopPanel.Controls.Add(this.pictureBox1);
            this.FormPlayerTopPanel.Controls.Add(this.ClosePlayerForm);
            this.FormPlayerTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormPlayerTopPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPlayerTopPanel.Name = "FormPlayerTopPanel";
            this.FormPlayerTopPanel.Size = new System.Drawing.Size(379, 37);
            this.FormPlayerTopPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ClosePlayerForm
            // 
            this.ClosePlayerForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClosePlayerForm.FlatAppearance.BorderSize = 0;
            this.ClosePlayerForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.ClosePlayerForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.ClosePlayerForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClosePlayerForm.Image = ((System.Drawing.Image)(resources.GetObject("ClosePlayerForm.Image")));
            this.ClosePlayerForm.Location = new System.Drawing.Point(345, 0);
            this.ClosePlayerForm.Name = "ClosePlayerForm";
            this.ClosePlayerForm.Size = new System.Drawing.Size(34, 37);
            this.ClosePlayerForm.TabIndex = 0;
            this.ClosePlayerForm.UseVisualStyleBackColor = true;
            this.ClosePlayerForm.Click += new System.EventHandler(this.ClosePlayerForm_Click);
            // 
            // txtCIN
            // 
            this.txtCIN.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCIN.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.txtCIN.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCIN.BorderThickness = 3;
            this.txtCIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCIN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCIN.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCIN.isPassword = false;
            this.txtCIN.Location = new System.Drawing.Point(22, 61);
            this.txtCIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(317, 35);
            this.txtCIN.TabIndex = 0;
            this.txtCIN.Text = "Entre the CIN of the Player";
            this.txtCIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCIN.Enter += new System.EventHandler(this.txtCIN_Enter);
            this.txtCIN.Leave += new System.EventHandler(this.txtCIN_Leave);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtFirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.TxtFirstName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtFirstName.BorderThickness = 3;
            this.TxtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtFirstName.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtFirstName.isPassword = false;
            this.TxtFirstName.Location = new System.Drawing.Point(22, 175);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(317, 35);
            this.TxtFirstName.TabIndex = 2;
            this.TxtFirstName.Text = "Entre the FirstName of the Player";
            this.TxtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFirstName.Enter += new System.EventHandler(this.TxtFirstName_Enter);
            this.TxtFirstName.Leave += new System.EventHandler(this.TxtFirstName_Leave);
            // 
            // TxtPosition
            // 
            this.TxtPosition.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtPosition.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.TxtPosition.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtPosition.BorderThickness = 3;
            this.TxtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtPosition.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtPosition.isPassword = false;
            this.TxtPosition.Location = new System.Drawing.Point(22, 232);
            this.TxtPosition.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.Size = new System.Drawing.Size(317, 35);
            this.TxtPosition.TabIndex = 3;
            this.TxtPosition.Text = "Entre the Position of the Player";
            this.TxtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPosition.Enter += new System.EventHandler(this.TxtPosition_Enter);
            this.TxtPosition.Leave += new System.EventHandler(this.TxtPosition_Leave);
            // 
            // TxtNumbre
            // 
            this.TxtNumbre.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtNumbre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.TxtNumbre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtNumbre.BorderThickness = 3;
            this.TxtNumbre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNumbre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNumbre.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtNumbre.isPassword = false;
            this.TxtNumbre.Location = new System.Drawing.Point(22, 289);
            this.TxtNumbre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumbre.Name = "TxtNumbre";
            this.TxtNumbre.Size = new System.Drawing.Size(317, 35);
            this.TxtNumbre.TabIndex = 4;
            this.TxtNumbre.Text = "Entre the Numbre of the Player";
            this.TxtNumbre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNumbre.Enter += new System.EventHandler(this.TxtNumbre_Enter);
            this.TxtNumbre.Leave += new System.EventHandler(this.TxtNumbre_Leave);
            // 
            // TxtLastName
            // 
            this.TxtLastName.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtLastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.TxtLastName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtLastName.BorderThickness = 3;
            this.TxtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtLastName.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtLastName.isPassword = false;
            this.TxtLastName.Location = new System.Drawing.Point(22, 118);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(317, 35);
            this.TxtLastName.TabIndex = 1;
            this.TxtLastName.Text = "Entre the LastName of the Player";
            this.TxtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLastName.Enter += new System.EventHandler(this.TxtLastName_Enter);
            this.TxtLastName.Leave += new System.EventHandler(this.TxtLastName_Leave);
            // 
            // Dtpplayer
            // 
            this.Dtpplayer.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.Dtpplayer.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.Dtpplayer.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.Dtpplayer.Location = new System.Drawing.Point(137, 344);
            this.Dtpplayer.Name = "Dtpplayer";
            this.Dtpplayer.Size = new System.Drawing.Size(202, 26);
            this.Dtpplayer.TabIndex = 5;
            // 
            // comboPlayerTeam
            // 
            this.comboPlayerTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.comboPlayerTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPlayerTeam.ForeColor = System.Drawing.Color.White;
            this.comboPlayerTeam.FormattingEnabled = true;
            this.comboPlayerTeam.Location = new System.Drawing.Point(22, 394);
            this.comboPlayerTeam.Name = "comboPlayerTeam";
            this.comboPlayerTeam.Size = new System.Drawing.Size(317, 28);
            this.comboPlayerTeam.TabIndex = 6;
            this.comboPlayerTeam.Text = "--Team--";
            // 
            // ButtonAddPlayer
            // 
            this.ButtonAddPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.ButtonAddPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonAddPlayer.Enabled = false;
            this.ButtonAddPlayer.FlatAppearance.BorderSize = 0;
            this.ButtonAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddPlayer.ForeColor = System.Drawing.Color.White;
            this.ButtonAddPlayer.Location = new System.Drawing.Point(0, 452);
            this.ButtonAddPlayer.Name = "ButtonAddPlayer";
            this.ButtonAddPlayer.Size = new System.Drawing.Size(379, 40);
            this.ButtonAddPlayer.TabIndex = 10;
            this.ButtonAddPlayer.Text = "OK";
            this.ButtonAddPlayer.UseVisualStyleBackColor = false;
            this.ButtonAddPlayer.Click += new System.EventHandler(this.ButtonAddPlayer_Click);
            // 
            // ButtonEditPlayer
            // 
            this.ButtonEditPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.ButtonEditPlayer.Enabled = false;
            this.ButtonEditPlayer.FlatAppearance.BorderSize = 0;
            this.ButtonEditPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditPlayer.ForeColor = System.Drawing.Color.White;
            this.ButtonEditPlayer.Location = new System.Drawing.Point(0, 452);
            this.ButtonEditPlayer.Name = "ButtonEditPlayer";
            this.ButtonEditPlayer.Size = new System.Drawing.Size(379, 40);
            this.ButtonEditPlayer.TabIndex = 7;
            this.ButtonEditPlayer.Text = "OK";
            this.ButtonEditPlayer.UseVisualStyleBackColor = false;
            this.ButtonEditPlayer.Click += new System.EventHandler(this.ButtonEditPlayer_Click);
            // 
            // bunifuDragControlPlayer
            // 
            this.bunifuDragControlPlayer.Fixed = true;
            this.bunifuDragControlPlayer.Horizontal = true;
            this.bunifuDragControlPlayer.TargetControl = this.FormPlayerTopPanel;
            this.bunifuDragControlPlayer.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date of Birth :";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(379, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonEditPlayer);
            this.Controls.Add(this.ButtonAddPlayer);
            this.Controls.Add(this.comboPlayerTeam);
            this.Controls.Add(this.Dtpplayer);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtNumbre);
            this.Controls.Add(this.TxtPosition);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.txtCIN);
            this.Controls.Add(this.FormPlayerTopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerForm";
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.FormPlayerTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormPlayerTopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClosePlayerForm;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtFirstName;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtPosition;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtNumbre;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtLastName;
        private System.Windows.Forms.DateTimePicker Dtpplayer;
        private System.Windows.Forms.ComboBox comboPlayerTeam;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlPlayer;
        public System.Windows.Forms.Button ButtonAddPlayer;
        public System.Windows.Forms.Button ButtonEditPlayer;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtCIN;
    }
}