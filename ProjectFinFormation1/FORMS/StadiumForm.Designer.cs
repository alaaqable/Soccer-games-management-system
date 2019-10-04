namespace ProjectFinFormation1
{
    partial class StadiumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StadiumForm));
            this.FormStadiumTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseStadiumForm = new System.Windows.Forms.Button();
            this.buttonEditStadium = new System.Windows.Forms.Button();
            this.bunifuDragControlStadium = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.buttonAddStadium = new System.Windows.Forms.Button();
            this.txtIDStadium = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtNameStadium = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtCityStadium = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.FormStadiumTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormStadiumTopPanel
            // 
            this.FormStadiumTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.FormStadiumTopPanel.Controls.Add(this.pictureBox1);
            this.FormStadiumTopPanel.Controls.Add(this.CloseStadiumForm);
            this.FormStadiumTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormStadiumTopPanel.Location = new System.Drawing.Point(0, 0);
            this.FormStadiumTopPanel.Name = "FormStadiumTopPanel";
            this.FormStadiumTopPanel.Size = new System.Drawing.Size(379, 37);
            this.FormStadiumTopPanel.TabIndex = 27;
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
            // CloseStadiumForm
            // 
            this.CloseStadiumForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseStadiumForm.FlatAppearance.BorderSize = 0;
            this.CloseStadiumForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseStadiumForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.CloseStadiumForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseStadiumForm.Image = ((System.Drawing.Image)(resources.GetObject("CloseStadiumForm.Image")));
            this.CloseStadiumForm.Location = new System.Drawing.Point(345, 0);
            this.CloseStadiumForm.Name = "CloseStadiumForm";
            this.CloseStadiumForm.Size = new System.Drawing.Size(34, 37);
            this.CloseStadiumForm.TabIndex = 0;
            this.CloseStadiumForm.UseVisualStyleBackColor = true;
            this.CloseStadiumForm.Click += new System.EventHandler(this.CloseStadiumForm_Click);
            // 
            // buttonEditStadium
            // 
            this.buttonEditStadium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.buttonEditStadium.Enabled = false;
            this.buttonEditStadium.FlatAppearance.BorderSize = 0;
            this.buttonEditStadium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditStadium.ForeColor = System.Drawing.Color.White;
            this.buttonEditStadium.Location = new System.Drawing.Point(0, 280);
            this.buttonEditStadium.Name = "buttonEditStadium";
            this.buttonEditStadium.Size = new System.Drawing.Size(379, 40);
            this.buttonEditStadium.TabIndex = 3;
            this.buttonEditStadium.Text = "OK";
            this.buttonEditStadium.UseVisualStyleBackColor = false;
            this.buttonEditStadium.Click += new System.EventHandler(this.buttonEditStadium_Click);
            // 
            // bunifuDragControlStadium
            // 
            this.bunifuDragControlStadium.Fixed = true;
            this.bunifuDragControlStadium.Horizontal = true;
            this.bunifuDragControlStadium.TargetControl = this.FormStadiumTopPanel;
            this.bunifuDragControlStadium.Vertical = true;
            // 
            // buttonAddStadium
            // 
            this.buttonAddStadium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.buttonAddStadium.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddStadium.Enabled = false;
            this.buttonAddStadium.FlatAppearance.BorderSize = 0;
            this.buttonAddStadium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStadium.ForeColor = System.Drawing.Color.White;
            this.buttonAddStadium.Location = new System.Drawing.Point(0, 280);
            this.buttonAddStadium.Name = "buttonAddStadium";
            this.buttonAddStadium.Size = new System.Drawing.Size(379, 40);
            this.buttonAddStadium.TabIndex = 30;
            this.buttonAddStadium.Text = "OK";
            this.buttonAddStadium.UseVisualStyleBackColor = false;
            this.buttonAddStadium.Click += new System.EventHandler(this.buttonAddStadium_Click);
            // 
            // txtIDStadium
            // 
            this.txtIDStadium.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.txtIDStadium.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.txtIDStadium.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.txtIDStadium.BorderThickness = 3;
            this.txtIDStadium.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDStadium.Enabled = false;
            this.txtIDStadium.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDStadium.ForeColor = System.Drawing.Color.DarkGray;
            this.txtIDStadium.isPassword = false;
            this.txtIDStadium.Location = new System.Drawing.Point(28, 82);
            this.txtIDStadium.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDStadium.Name = "txtIDStadium";
            this.txtIDStadium.Size = new System.Drawing.Size(321, 35);
            this.txtIDStadium.TabIndex = 0;
            this.txtIDStadium.Text = "Entre the ID of the Stadium";
            this.txtIDStadium.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIDStadium.Enter += new System.EventHandler(this.txtIDStadium_Enter);
            this.txtIDStadium.Leave += new System.EventHandler(this.txtIDStadium_Leave);
            // 
            // TxtNameStadium
            // 
            this.TxtNameStadium.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.TxtNameStadium.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.TxtNameStadium.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.TxtNameStadium.BorderThickness = 3;
            this.TxtNameStadium.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNameStadium.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNameStadium.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtNameStadium.isPassword = false;
            this.TxtNameStadium.Location = new System.Drawing.Point(28, 142);
            this.TxtNameStadium.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNameStadium.Name = "TxtNameStadium";
            this.TxtNameStadium.Size = new System.Drawing.Size(321, 35);
            this.TxtNameStadium.TabIndex = 1;
            this.TxtNameStadium.Text = "Entre the Name of the Stadium";
            this.TxtNameStadium.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNameStadium.Enter += new System.EventHandler(this.TxtNameStadium_Enter);
            this.TxtNameStadium.Leave += new System.EventHandler(this.TxtNameStadium_Leave);
            // 
            // TxtCityStadium
            // 
            this.TxtCityStadium.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.TxtCityStadium.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.TxtCityStadium.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.TxtCityStadium.BorderThickness = 3;
            this.TxtCityStadium.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCityStadium.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtCityStadium.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtCityStadium.isPassword = false;
            this.TxtCityStadium.Location = new System.Drawing.Point(28, 203);
            this.TxtCityStadium.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCityStadium.Name = "TxtCityStadium";
            this.TxtCityStadium.Size = new System.Drawing.Size(321, 35);
            this.TxtCityStadium.TabIndex = 2;
            this.TxtCityStadium.Text = "Entre the City of the Stadium";
            this.TxtCityStadium.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCityStadium.Enter += new System.EventHandler(this.TxtCityStadium_Enter);
            this.TxtCityStadium.Leave += new System.EventHandler(this.TxtCityStadium_Leave);
            // 
            // StadiumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(379, 320);
            this.Controls.Add(this.buttonEditStadium);
            this.Controls.Add(this.TxtCityStadium);
            this.Controls.Add(this.buttonAddStadium);
            this.Controls.Add(this.TxtNameStadium);
            this.Controls.Add(this.txtIDStadium);
            this.Controls.Add(this.FormStadiumTopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StadiumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StadiumForm";
            this.Load += new System.EventHandler(this.StadiumForm_Load);
            this.FormStadiumTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel FormStadiumTopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseStadiumForm;
        public System.Windows.Forms.Button buttonEditStadium;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlStadium;
        public System.Windows.Forms.Button buttonAddStadium;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtIDStadium;
        public Bunifu.Framework.UI.BunifuMetroTextbox TxtNameStadium;
        public Bunifu.Framework.UI.BunifuMetroTextbox TxtCityStadium;
    }
}