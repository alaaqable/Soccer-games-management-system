namespace ProjectFinFormation1
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.FormGameTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseGameForm = new System.Windows.Forms.Button();
            this.ButtonAddGame = new System.Windows.Forms.Button();
            this.buttonEditGame = new System.Windows.Forms.Button();
            this.bunifuDragGame = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.comboTeamHome = new System.Windows.Forms.ComboBox();
            this.comboTeamAway = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MTxtTimeGame = new System.Windows.Forms.MaskedTextBox();
            this.comboReferee = new System.Windows.Forms.ComboBox();
            this.comboStaduim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtdateofgame = new System.Windows.Forms.DateTimePicker();
            this.FormGameTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormGameTopPanel
            // 
            this.FormGameTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.FormGameTopPanel.Controls.Add(this.pictureBox1);
            this.FormGameTopPanel.Controls.Add(this.CloseGameForm);
            this.FormGameTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormGameTopPanel.Location = new System.Drawing.Point(0, 0);
            this.FormGameTopPanel.Name = "FormGameTopPanel";
            this.FormGameTopPanel.Size = new System.Drawing.Size(379, 37);
            this.FormGameTopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CloseGameForm
            // 
            this.CloseGameForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseGameForm.FlatAppearance.BorderSize = 0;
            this.CloseGameForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseGameForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.CloseGameForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseGameForm.Image = ((System.Drawing.Image)(resources.GetObject("CloseGameForm.Image")));
            this.CloseGameForm.Location = new System.Drawing.Point(345, 0);
            this.CloseGameForm.Name = "CloseGameForm";
            this.CloseGameForm.Size = new System.Drawing.Size(34, 37);
            this.CloseGameForm.TabIndex = 0;
            this.CloseGameForm.UseVisualStyleBackColor = true;
            this.CloseGameForm.Click += new System.EventHandler(this.CloseGameForm_Click);
            // 
            // ButtonAddGame
            // 
            this.ButtonAddGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.ButtonAddGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonAddGame.Enabled = false;
            this.ButtonAddGame.FlatAppearance.BorderSize = 0;
            this.ButtonAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddGame.ForeColor = System.Drawing.Color.White;
            this.ButtonAddGame.Location = new System.Drawing.Point(0, 452);
            this.ButtonAddGame.Name = "ButtonAddGame";
            this.ButtonAddGame.Size = new System.Drawing.Size(379, 40);
            this.ButtonAddGame.TabIndex = 12;
            this.ButtonAddGame.Text = "OK";
            this.ButtonAddGame.UseVisualStyleBackColor = false;
            this.ButtonAddGame.Click += new System.EventHandler(this.ButtonAddGame_Click);
            // 
            // buttonEditGame
            // 
            this.buttonEditGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.buttonEditGame.Enabled = false;
            this.buttonEditGame.FlatAppearance.BorderSize = 0;
            this.buttonEditGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditGame.ForeColor = System.Drawing.Color.White;
            this.buttonEditGame.Location = new System.Drawing.Point(0, 452);
            this.buttonEditGame.Name = "buttonEditGame";
            this.buttonEditGame.Size = new System.Drawing.Size(379, 40);
            this.buttonEditGame.TabIndex = 7;
            this.buttonEditGame.Text = "OK";
            this.buttonEditGame.UseVisualStyleBackColor = false;
            this.buttonEditGame.Click += new System.EventHandler(this.buttonEditGame_Click);
            // 
            // bunifuDragGame
            // 
            this.bunifuDragGame.Fixed = true;
            this.bunifuDragGame.Horizontal = true;
            this.bunifuDragGame.TargetControl = this.FormGameTopPanel;
            this.bunifuDragGame.Vertical = true;
            // 
            // comboTeamHome
            // 
            this.comboTeamHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.comboTeamHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTeamHome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboTeamHome.FormattingEnabled = true;
            this.comboTeamHome.Location = new System.Drawing.Point(10, 139);
            this.comboTeamHome.Name = "comboTeamHome";
            this.comboTeamHome.Size = new System.Drawing.Size(149, 28);
            this.comboTeamHome.TabIndex = 1;
            this.comboTeamHome.Text = "  --Team Home--";
            // 
            // comboTeamAway
            // 
            this.comboTeamAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.comboTeamAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTeamAway.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboTeamAway.FormattingEnabled = true;
            this.comboTeamAway.Location = new System.Drawing.Point(220, 139);
            this.comboTeamAway.Name = "comboTeamAway";
            this.comboTeamAway.Size = new System.Drawing.Size(149, 28);
            this.comboTeamAway.TabIndex = 2;
            this.comboTeamAway.Text = "   --Team Away--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(172, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "-VS-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(216, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Time :";
            // 
            // MTxtTimeGame
            // 
            this.MTxtTimeGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.MTxtTimeGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTxtTimeGame.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtTimeGame.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MTxtTimeGame.Location = new System.Drawing.Point(270, 212);
            this.MTxtTimeGame.Mask = "00:00";
            this.MTxtTimeGame.Name = "MTxtTimeGame";
            this.MTxtTimeGame.Size = new System.Drawing.Size(47, 27);
            this.MTxtTimeGame.TabIndex = 4;
            this.MTxtTimeGame.ValidatingType = typeof(System.DateTime);
            // 
            // comboReferee
            // 
            this.comboReferee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.comboReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboReferee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboReferee.FormattingEnabled = true;
            this.comboReferee.Location = new System.Drawing.Point(16, 282);
            this.comboReferee.Name = "comboReferee";
            this.comboReferee.Size = new System.Drawing.Size(351, 28);
            this.comboReferee.TabIndex = 5;
            this.comboReferee.Text = "--Referee--";
            // 
            // comboStaduim
            // 
            this.comboStaduim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.comboStaduim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStaduim.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboStaduim.FormattingEnabled = true;
            this.comboStaduim.Location = new System.Drawing.Point(16, 344);
            this.comboStaduim.Name = "comboStaduim";
            this.comboStaduim.Size = new System.Drawing.Size(351, 28);
            this.comboStaduim.TabIndex = 6;
            this.comboStaduim.Text = "--Staduim--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Game ID :";
            // 
            // txtID
            // 
            this.txtID.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.txtID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtID.BorderThickness = 3;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.isPassword = false;
            this.txtID.Location = new System.Drawing.Point(122, 64);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 31);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtdateofgame
            // 
            this.txtdateofgame.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdateofgame.Location = new System.Drawing.Point(63, 213);
            this.txtdateofgame.Name = "txtdateofgame";
            this.txtdateofgame.Size = new System.Drawing.Size(146, 26);
            this.txtdateofgame.TabIndex = 3;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(379, 492);
            this.Controls.Add(this.MTxtTimeGame);
            this.Controls.Add(this.txtdateofgame);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboStaduim);
            this.Controls.Add(this.comboReferee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTeamAway);
            this.Controls.Add(this.comboTeamHome);
            this.Controls.Add(this.buttonEditGame);
            this.Controls.Add(this.ButtonAddGame);
            this.Controls.Add(this.FormGameTopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.FormGameTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormGameTopPanel;
        private System.Windows.Forms.Button CloseGameForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button ButtonAddGame;
        public System.Windows.Forms.Button buttonEditGame;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragGame;
        private System.Windows.Forms.ComboBox comboTeamHome;
        private System.Windows.Forms.ComboBox comboTeamAway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MTxtTimeGame;
        private System.Windows.Forms.ComboBox comboReferee;
        private System.Windows.Forms.ComboBox comboStaduim;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        private System.Windows.Forms.DateTimePicker txtdateofgame;
    }
}