namespace ProjectFinFormation1
{
    partial class RefereeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefereeForm));
            this.buttonAddReferee = new System.Windows.Forms.Button();
            this.TxtNameReferee = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCinReferee = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.FormRefereeTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseRefereeForm = new System.Windows.Forms.Button();
            this.buttonEditReferee = new System.Windows.Forms.Button();
            this.bunifuDragControlReferee = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FormRefereeTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddReferee
            // 
            this.buttonAddReferee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.buttonAddReferee.Enabled = false;
            this.buttonAddReferee.FlatAppearance.BorderSize = 0;
            this.buttonAddReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddReferee.ForeColor = System.Drawing.Color.White;
            this.buttonAddReferee.Location = new System.Drawing.Point(0, 280);
            this.buttonAddReferee.Name = "buttonAddReferee";
            this.buttonAddReferee.Size = new System.Drawing.Size(379, 40);
            this.buttonAddReferee.TabIndex = 36;
            this.buttonAddReferee.Text = "OK";
            this.buttonAddReferee.UseVisualStyleBackColor = false;
            this.buttonAddReferee.Click += new System.EventHandler(this.buttonAddReferee_Click);
            // 
            // TxtNameReferee
            // 
            this.TxtNameReferee.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.TxtNameReferee.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.TxtNameReferee.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.TxtNameReferee.BorderThickness = 3;
            this.TxtNameReferee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNameReferee.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNameReferee.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtNameReferee.isPassword = false;
            this.TxtNameReferee.Location = new System.Drawing.Point(28, 175);
            this.TxtNameReferee.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNameReferee.Name = "TxtNameReferee";
            this.TxtNameReferee.Size = new System.Drawing.Size(321, 35);
            this.TxtNameReferee.TabIndex = 1;
            this.TxtNameReferee.Text = "Entre the Name of the Referee";
            this.TxtNameReferee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNameReferee.Enter += new System.EventHandler(this.TxtNameReferee_Enter);
            this.TxtNameReferee.Leave += new System.EventHandler(this.TxtNameReferee_Leave);
            // 
            // txtCinReferee
            // 
            this.txtCinReferee.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.txtCinReferee.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.txtCinReferee.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.txtCinReferee.BorderThickness = 3;
            this.txtCinReferee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCinReferee.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCinReferee.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCinReferee.isPassword = false;
            this.txtCinReferee.Location = new System.Drawing.Point(28, 94);
            this.txtCinReferee.Margin = new System.Windows.Forms.Padding(4);
            this.txtCinReferee.Name = "txtCinReferee";
            this.txtCinReferee.Size = new System.Drawing.Size(321, 35);
            this.txtCinReferee.TabIndex = 0;
            this.txtCinReferee.Text = "Entre the CIN of the Referee";
            this.txtCinReferee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCinReferee.Enter += new System.EventHandler(this.txtCinReferee_Enter);
            this.txtCinReferee.Leave += new System.EventHandler(this.txtCinReferee_Leave);
            // 
            // FormRefereeTopPanel
            // 
            this.FormRefereeTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.FormRefereeTopPanel.Controls.Add(this.pictureBox1);
            this.FormRefereeTopPanel.Controls.Add(this.CloseRefereeForm);
            this.FormRefereeTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormRefereeTopPanel.Location = new System.Drawing.Point(0, 0);
            this.FormRefereeTopPanel.Name = "FormRefereeTopPanel";
            this.FormRefereeTopPanel.Size = new System.Drawing.Size(379, 37);
            this.FormRefereeTopPanel.TabIndex = 33;
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
            // CloseRefereeForm
            // 
            this.CloseRefereeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseRefereeForm.FlatAppearance.BorderSize = 0;
            this.CloseRefereeForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseRefereeForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.CloseRefereeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseRefereeForm.Image = ((System.Drawing.Image)(resources.GetObject("CloseRefereeForm.Image")));
            this.CloseRefereeForm.Location = new System.Drawing.Point(345, 0);
            this.CloseRefereeForm.Name = "CloseRefereeForm";
            this.CloseRefereeForm.Size = new System.Drawing.Size(34, 37);
            this.CloseRefereeForm.TabIndex = 0;
            this.CloseRefereeForm.UseVisualStyleBackColor = true;
            this.CloseRefereeForm.Click += new System.EventHandler(this.CloseRefereeForm_Click);
            // 
            // buttonEditReferee
            // 
            this.buttonEditReferee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.buttonEditReferee.Enabled = false;
            this.buttonEditReferee.FlatAppearance.BorderSize = 0;
            this.buttonEditReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditReferee.ForeColor = System.Drawing.Color.White;
            this.buttonEditReferee.Location = new System.Drawing.Point(0, 280);
            this.buttonEditReferee.Name = "buttonEditReferee";
            this.buttonEditReferee.Size = new System.Drawing.Size(379, 40);
            this.buttonEditReferee.TabIndex = 2;
            this.buttonEditReferee.Text = "OK";
            this.buttonEditReferee.UseVisualStyleBackColor = false;
            this.buttonEditReferee.Click += new System.EventHandler(this.buttonEditReferee_Click);
            // 
            // bunifuDragControlReferee
            // 
            this.bunifuDragControlReferee.Fixed = true;
            this.bunifuDragControlReferee.Horizontal = true;
            this.bunifuDragControlReferee.TargetControl = this.FormRefereeTopPanel;
            this.bunifuDragControlReferee.Vertical = true;
            // 
            // RefereeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(379, 320);
            this.Controls.Add(this.buttonEditReferee);
            this.Controls.Add(this.buttonAddReferee);
            this.Controls.Add(this.TxtNameReferee);
            this.Controls.Add(this.txtCinReferee);
            this.Controls.Add(this.FormRefereeTopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RefereeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RefereeForm";
            this.Load += new System.EventHandler(this.RefereeForm_Load);
            this.FormRefereeTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonAddReferee;
        private System.Windows.Forms.Panel FormRefereeTopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseRefereeForm;
        public System.Windows.Forms.Button buttonEditReferee;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlReferee;
        public Bunifu.Framework.UI.BunifuMetroTextbox TxtNameReferee;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtCinReferee;
    }
}