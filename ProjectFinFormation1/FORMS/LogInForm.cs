using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProjectFinFormation1
{
    public partial class LogInForm : Form
    {
        Graphic_Class Graphic = new Graphic_Class();
        DBManager dBManager;
        DataSet dsinfo = new DataSet();
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            Graphic.TextboxControler(TxtEmail, "Example@gmail.com", "189, 189, 189");
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            
            if (!Regex.IsMatch(TxtEmail.Text, "^[a-zA-Z]+(.|_|-)?[a-zA-Z0-9]*@[A-Za-z]+.[A-Za-z]{3}$"))
            {
                TxtEmail.Text = "";
                ErrorLabel.Text = "Error : Email Invalid !";
            }
            else
            {
                ErrorLabel.Text = "";
            }
            Graphic.TextboxControler(TxtEmail, "Example@gmail.com", "189, 189, 189");
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            Graphic.TextboxControler(TxtPassword, "Password", "189, 189, 189");
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            Graphic.TextboxControler(TxtPassword, "Password", "189, 189, 189");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            dBManager = new DBManager();
            dBManager.Query("select * from User_Match");
            dsinfo = dBManager.Fill_DS("User_Match");
            dBManager.Close_Connection();
            int p = -1;
            if(dsinfo.Tables["User_Match"].Rows.Count > 0)
            {
                for (int i = 0; i < dsinfo.Tables["User_Match"].Rows.Count; i++)
                {
                    if (TxtEmail.Text == dsinfo.Tables["User_Match"].Rows[i]["Email"].ToString() && TxtPassword.Text == dsinfo.Tables["User_Match"].Rows[i]["Pass_Word"].ToString())
                    {
                        p = i;
                        break;
                    }
                }
                if (p != -1)
                {
                    string CIN = dsinfo.Tables["User_Match"].Rows[p]["Cin"].ToString();
                    string Name = dsinfo.Tables["User_Match"].Rows[p]["FullName"].ToString();
                    string Email = dsinfo.Tables["User_Match"].Rows[p]["Email"].ToString();
                    this.Hide();
                    Form1 f1 = new Form1(CIN, Name, Email);
                    f1.Show();
                }
                else
                {
                    ErrorLabel.Text = "Error : Email or Password is Incorrect!";
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(TxtPassword.isPassword == true)
            {
                TxtPassword.isPassword = false;
                BtnVI_INV.Image = Image.FromFile(@"Ico\Invisible_25px.png");
            }
            else
            {
                TxtPassword.isPassword = true;
                BtnVI_INV.Image = Image.FromFile(@"Ico\Eye_25px.png");
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnOK.PerformClick();
            }
        }
    }
}
