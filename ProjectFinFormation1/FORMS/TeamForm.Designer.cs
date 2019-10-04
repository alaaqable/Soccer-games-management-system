namespace ProjectFinFormation1
{
    partial class TeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamForm));
            this.buttonEditTeam = new System.Windows.Forms.Button();
            this.ButtonAddTeam = new System.Windows.Forms.Button();
            this.TxtCityTeam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpTeam = new System.Windows.Forms.DateTimePicker();
            this.TxtNameTeam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtTeamCoach = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtIDTeam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.FormTeamTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseTeamForm = new System.Windows.Forms.Button();
            this.comboTeamStade = new System.Windows.Forms.ComboBox();
            this.bunifuDragControlTeam = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FormTeamTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditTeam
            // 
            this.buttonEditTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonEditTeam.Enabled = false;
            this.buttonEditTeam.FlatAppearance.BorderSize = 0;
            this.buttonEditTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditTeam.ForeColor = System.Drawing.Color.White;
            this.buttonEditTeam.Location = new System.Drawing.Point(0, 452);
            this.buttonEditTeam.Name = "buttonEditTeam";
            this.buttonEditTeam.Size = new System.Drawing.Size(379, 40);
            this.buttonEditTeam.TabIndex = 6;
            this.buttonEditTeam.Text = "OK";
            this.buttonEditTeam.UseVisualStyleBackColor = false;
            this.buttonEditTeam.Click += new System.EventHandler(this.buttonEditTeam_Click);
            // 
            // ButtonAddTeam
            // 
            this.ButtonAddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ButtonAddTeam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonAddTeam.Enabled = false;
            this.ButtonAddTeam.FlatAppearance.BorderSize = 0;
            this.ButtonAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddTeam.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTeam.Location = new System.Drawing.Point(0, 452);
            this.ButtonAddTeam.Name = "ButtonAddTeam";
            this.ButtonAddTeam.Size = new System.Drawing.Size(379, 40);
            this.ButtonAddTeam.TabIndex = 25;
            this.ButtonAddTeam.Text = "OK";
            this.ButtonAddTeam.UseVisualStyleBackColor = false;
            this.ButtonAddTeam.Click += new System.EventHandler(this.ButtonAddTeam_Click);
            // 
            // TxtCityTeam
            // 
            this.TxtCityTeam.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.TxtCityTeam.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TxtCityTeam.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.TxtCityTeam.BorderThickness = 3;
            this.TxtCityTeam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCityTeam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtCityTeam.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtCityTeam.isPassword = false;
            this.TxtCityTeam.Location = new System.Drawing.Point(28, 241);
            this.TxtCityTeam.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCityTeam.Name = "TxtCityTeam";
            this.TxtCityTeam.Size = new System.Drawing.Size(317, 35);
            this.TxtCityTeam.TabIndex = 2;
            this.TxtCityTeam.Text = "Entre the City of the Team";
            this.TxtCityTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCityTeam.Enter += new System.EventHandler(this.TxtCityTeam_Enter);
            this.TxtCityTeam.Leave += new System.EventHandler(this.TxtCityTeam_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date of Creation :";
            // 
            // DtpTeam
            // 
            this.DtpTeam.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.DtpTeam.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpTeam.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.DtpTeam.Location = new System.Drawing.Point(174, 298);
            this.DtpTeam.Name = "DtpTeam";
            this.DtpTeam.Size = new System.Drawing.Size(175, 26);
            this.DtpTeam.TabIndex = 3;
            // 
            // TxtNameTeam
            // 
            this.TxtNameTeam.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.TxtNameTeam.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TxtNameTeam.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.TxtNameTeam.BorderThickness = 3;
            this.TxtNameTeam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNameTeam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNameTeam.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtNameTeam.isPassword = false;
            this.TxtNameTeam.Location = new System.Drawing.Point(28, 189);
            this.TxtNameTeam.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNameTeam.Name = "TxtNameTeam";
            this.TxtNameTeam.Size = new System.Drawing.Size(321, 35);
            this.TxtNameTeam.TabIndex = 1;
            this.TxtNameTeam.Text = "Entre the Name of the Team";
            this.TxtNameTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNameTeam.Enter += new System.EventHandler(this.TxtNameTeam_Enter);
            this.TxtNameTeam.Leave += new System.EventHandler(this.TxtNameTeam_Leave);
            // 
            // TxtTeamCoach
            // 
            this.TxtTeamCoach.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.TxtTeamCoach.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TxtTeamCoach.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.TxtTeamCoach.BorderThickness = 3;
            this.TxtTeamCoach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTeamCoach.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtTeamCoach.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtTeamCoach.isPassword = false;
            this.TxtTeamCoach.Location = new System.Drawing.Point(28, 348);
            this.TxtTeamCoach.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTeamCoach.Name = "TxtTeamCoach";
            this.TxtTeamCoach.Size = new System.Drawing.Size(321, 35);
            this.TxtTeamCoach.TabIndex = 4;
            this.TxtTeamCoach.Text = "Entre the Coach Name";
            this.TxtTeamCoach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtTeamCoach.Enter += new System.EventHandler(this.TxtTeamCoach_Enter);
            this.TxtTeamCoach.Leave += new System.EventHandler(this.TxtTeamCoach_Leave);
            // 
            // txtIDTeam
            // 
            this.txtIDTeam.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtIDTeam.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtIDTeam.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtIDTeam.BorderThickness = 3;
            this.txtIDTeam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDTeam.Enabled = false;
            this.txtIDTeam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDTeam.ForeColor = System.Drawing.Color.DarkGray;
            this.txtIDTeam.isPassword = false;
            this.txtIDTeam.Location = new System.Drawing.Point(28, 137);
            this.txtIDTeam.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDTeam.Name = "txtIDTeam";
            this.txtIDTeam.Size = new System.Drawing.Size(321, 35);
            this.txtIDTeam.TabIndex = 0;
            this.txtIDTeam.Text = "Entre the ID of the Team";
            this.txtIDTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIDTeam.Enter += new System.EventHandler(this.txtIDTeam_Enter);
            this.txtIDTeam.Leave += new System.EventHandler(this.txtIDTeam_Leave);
            // 
            // FormTeamTopPanel
            // 
            this.FormTeamTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.FormTeamTopPanel.Controls.Add(this.pictureBox1);
            this.FormTeamTopPanel.Controls.Add(this.CloseTeamForm);
            this.FormTeamTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormTeamTopPanel.Location = new System.Drawing.Point(0, 0);
            this.FormTeamTopPanel.Name = "FormTeamTopPanel";
            this.FormTeamTopPanel.Size = new System.Drawing.Size(379, 37);
            this.FormTeamTopPanel.TabIndex = 18;
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
            // CloseTeamForm
            // 
            this.CloseTeamForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseTeamForm.FlatAppearance.BorderSize = 0;
            this.CloseTeamForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseTeamForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.CloseTeamForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseTeamForm.Image = ((System.Drawing.Image)(resources.GetObject("CloseTeamForm.Image")));
            this.CloseTeamForm.Location = new System.Drawing.Point(345, 0);
            this.CloseTeamForm.Name = "CloseTeamForm";
            this.CloseTeamForm.Size = new System.Drawing.Size(34, 37);
            this.CloseTeamForm.TabIndex = 0;
            this.CloseTeamForm.UseVisualStyleBackColor = true;
            this.CloseTeamForm.Click += new System.EventHandler(this.ClosePlayerForm_Click);
            // 
            // comboTeamStade
            // 
            this.comboTeamStade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.comboTeamStade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTeamStade.ForeColor = System.Drawing.Color.White;
            this.comboTeamStade.FormattingEnabled = true;
            this.comboTeamStade.Location = new System.Drawing.Point(28, 405);
            this.comboTeamStade.Name = "comboTeamStade";
            this.comboTeamStade.Size = new System.Drawing.Size(317, 28);
            this.comboTeamStade.TabIndex = 5;
            this.comboTeamStade.Text = "--Staduim--";
            // 
            // bunifuDragControlTeam
            // 
            this.bunifuDragControlTeam.Fixed = true;
            this.bunifuDragControlTeam.Horizontal = true;
            this.bunifuDragControlTeam.TargetControl = this.FormTeamTopPanel;
            this.bunifuDragControlTeam.Vertical = true;
            // 
            // PBLogo
            // 
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(124, 45);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(121, 86);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 28;
            this.PBLogo.TabStop = false;
            this.PBLogo.Click += new System.EventHandler(this.PBLogo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(379, 492);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.comboTeamStade);
            this.Controls.Add(this.buttonEditTeam);
            this.Controls.Add(this.ButtonAddTeam);
            this.Controls.Add(this.TxtCityTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpTeam);
            this.Controls.Add(this.TxtNameTeam);
            this.Controls.Add(this.TxtTeamCoach);
            this.Controls.Add(this.txtIDTeam);
            this.Controls.Add(this.FormTeamTopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamForm";
            this.Load += new System.EventHandler(this.TeamForm_Load);
            this.FormTeamTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonEditTeam;
        public System.Windows.Forms.Button ButtonAddTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel FormTeamTopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseTeamForm;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlTeam;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public Bunifu.Framework.UI.BunifuMetroTextbox TxtCityTeam;
        public System.Windows.Forms.DateTimePicker DtpTeam;
        public Bunifu.Framework.UI.BunifuMetroTextbox TxtNameTeam;
        public Bunifu.Framework.UI.BunifuMetroTextbox TxtTeamCoach;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtIDTeam;
        public System.Windows.Forms.ComboBox comboTeamStade;
        public System.Windows.Forms.PictureBox PBLogo;
    }
}