using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectFinFormation1
{
    public partial class Games : UserControl
    {
        int position;
        DBManager DBManager;
        GameForm GameForm;
        Graphic_Class Graphic = new Graphic_Class();
        DataSet dataSet = new DataSet();
        DataSet dsMatch1 = new DataSet();
        public Games()
        {
            InitializeComponent();
        }
        public Games(int position) : this()
        {
            this.position = position;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "  Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = ColorTranslator.FromHtml("#424242");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "  Search...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnAddGames_Click(object sender, EventArgs e)
        {
            GameForm = new GameForm();
            GameForm.ButtonAddGame.BringToFront();
            GameForm.ButtonAddGame.Enabled = true;
            //show the id of the entrie in the textbox
            if (dataGridView1.Rows.Count > 0)
            {
                GameForm.txtID.Text = (dataGridView1.Rows.Count + 1).ToString();
            }
            else
            {
                GameForm.txtID.Text = "1";
            }
            GameForm.ShowDialog();
        }

        private void btnEditGames_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.Rows.Count > 0)
                {
                  int Index = dataGridView1.SelectedCells[0].OwningRow.Index;
                  GameForm = new GameForm(Index);
                  GameForm.buttonEditGame.BringToFront();
                  GameForm.buttonEditGame.Enabled = true;
                  GameForm.txtID.Enabled = false;
                  GameForm.ShowDialog();
                }
         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error btnEditGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteGames_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                DBManager = new DBManager();
                DBManager.Query("delete From Matche where Match_ID = @id");
                DBManager.cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DBManager.ExecuteQuery();
                DBManager.Close_Connection();
                btnRefresh.PerformClick();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Deleting Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Games_Load(object sender, EventArgs e)
        {
            try
            {
            DBManager = new DBManager();
            DBManager.Query("Select_Games");
            dsMatch1 = DBManager.Fill_DS("Matche");
            for (int i = 0; i < dsMatch1.Tables["Matche"].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dsMatch1.Tables["Matche"].Rows[i]["Match_ID"].ToString(), Image.FromFile("TeamsLogo/" + dsMatch1.Tables["Matche"].Rows[i]["lhome"].ToString()), dsMatch1.Tables["Matche"].Rows[i]["Home"].ToString(),"VS", dsMatch1.Tables["Matche"].Rows[i]["Away"].ToString(), Image.FromFile("TeamsLogo/" + dsMatch1.Tables["Matche"].Rows[i]["laway"].ToString()), dsMatch1.Tables["Matche"].Rows[i]["Date_Matche"].ToString(), dsMatch1.Tables["Matche"].Rows[i]["Heure_Matche"].ToString(), dsMatch1.Tables["Matche"].Rows[i]["Nom"].ToString(), dsMatch1.Tables["Matche"].Rows[i]["Nom_Stade"]);
            }
            DBManager.Close_Connection();
            if (dataGridView1.Rows.Count > 0)
            {
                Positionlabel.Text = (dataGridView1.SelectedCells[0].OwningRow.Index + 1).ToString() + "/" + dataGridView1.Rows.Count.ToString();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Games_Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
            dsMatch1.Tables["Matche"].Rows.Clear();
            DBManager = new DBManager();
            DBManager.Query("Select_Games");
            DBManager.Refresh_DG(dsMatch1.Tables["Matche"]);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dsMatch1.Tables["Matche"].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dsMatch1.Tables["Matche"].Rows[i]["Match_ID"].ToString(), Image.FromFile("TeamsLogo/" + dsMatch1.Tables["Matche"].Rows[i]["lhome"].ToString()), dsMatch1.Tables["Matche"].Rows[i]["Home"].ToString(), "VS", dsMatch1.Tables["Matche"].Rows[i]["Away"].ToString(), Image.FromFile("TeamsLogo/" + dsMatch1.Tables["Matche"].Rows[i]["laway"].ToString()), dsMatch1.Tables["Matche"].Rows[i]["Date_Matche"].ToString(), dsMatch1.Tables["Matche"].Rows[i]["Heure_Matche"].ToString(), dsMatch1.Tables["Matche"].Rows[i]["Nom"].ToString(), dsMatch1.Tables["Matche"].Rows[i]["Nom_Stade"]);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "btnRefresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (txtSearch.Text != "  Search...")
            {
                DBManager = new DBManager();
                DBManager.Query("Select_Search_Game @search");
                DBManager.cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                dsMatch1.Tables["Matche"].Rows.Clear();
                DBManager.Refresh_DG(dsMatch1.Tables["Matche"]);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dsMatch1.Tables["Matche"].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dsMatch1.Tables["Matche"].Rows[i]["Match_ID"].ToString(), Image.FromFile("TeamsLogo/" + dsMatch1.Tables["Matche"].Rows[i]["lhome"].ToString()), dsMatch1.Tables["Matche"].Rows[i]["Home"].ToString(), "VS", dsMatch1.Tables["Matche"].Rows[i]["Away"].ToString(), Image.FromFile("TeamsLogo/" + dsMatch1.Tables["Matche"].Rows[i]["laway"].ToString()), dsMatch1.Tables["Matche"].Rows[i]["Date_Matche"].ToString(), dsMatch1.Tables["Matche"].Rows[i]["Heure_Matche"].ToString(), dsMatch1.Tables["Matche"].Rows[i]["Nom"].ToString(), dsMatch1.Tables["Matche"].Rows[i]["Nom_Stade"]);
                }
                DBManager.Close_Connection();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "txtSearch Games Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Graphic.selectFirst(dataGridView1, Positionlabel);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Graphic.selectPrevious(dataGridView1, Positionlabel);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Graphic.selectNext(dataGridView1, Positionlabel);
        }

        private void Btnlast_Click(object sender, EventArgs e)
        {
            Graphic.selectLast(dataGridView1, Positionlabel);
        }
    }
}
