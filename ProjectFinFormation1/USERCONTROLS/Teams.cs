using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinFormation1
{
    public partial class Teams : UserControl
    {
        DBManager DBManager;
        DataSet DataSet;
        TeamForm teamForm;
        Graphic_Class Graphic = new Graphic_Class();
        public Teams()
        {
            InitializeComponent();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "  Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = ColorTranslator.FromHtml("#424242");
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "  Search...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnAddGames_Click(object sender, EventArgs e)
        {
            teamForm = new TeamForm();
            teamForm.ButtonAddTeam.BringToFront();
            teamForm.ButtonAddTeam.Enabled = true;
            //show the id of the entrie in the textbox
            if (dataGridView1.Rows.Count > 0)
            {
                teamForm.txtIDTeam.Text = (dataGridView1.Rows.Count + 1).ToString();
            }
            else
            {
                teamForm.txtIDTeam.Text = "1";
            }
            teamForm.ShowDialog();
        }

        private void btnEditGames_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                int Index = dataGridView1.SelectedCells[0].OwningRow.Index;
                teamForm = new TeamForm(Index);
                teamForm.buttonEditTeam.BringToFront();
                teamForm.buttonEditTeam.Enabled = true;
                teamForm.txtIDTeam.Enabled = false;
                teamForm.ShowDialog();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Editing Teams", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void Teams_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet = new DataSet();
                DBManager = new DBManager();
                DBManager.Query("Select_Teams");
                DataSet = DBManager.Fill_DS("Equipe");
                for (int i = 0; i < DataSet.Tables["Equipe"].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(DataSet.Tables["Equipe"].Rows[i]["Equipe_ID"].ToString(),Image.FromFile("TeamsLogo/" + DataSet.Tables["Equipe"].Rows[i]["Logo"].ToString()), DataSet.Tables["Equipe"].Rows[i]["Team Name"].ToString(), DataSet.Tables["Equipe"].Rows[i]["City"].ToString(), DataSet.Tables["Equipe"].Rows[i]["Date Creation"].ToString(), DataSet.Tables["Equipe"].Rows[i]["Coach"].ToString(), DataSet.Tables["Equipe"].Rows[i]["Stade"]);
                }
                DBManager.Close_Connection();
                if (dataGridView1.Rows.Count > 0)
                {
                    Positionlabel.Text = (dataGridView1.SelectedCells[0].OwningRow.Index + 1).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Loading Teams", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
            DataSet.Tables["Equipe"].Rows.Clear();
            DBManager = new DBManager();
            DBManager.Query("Select_Teams");
            DBManager.Refresh_DG(DataSet.Tables["Equipe"]);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < DataSet.Tables["Equipe"].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(DataSet.Tables["Equipe"].Rows[i]["Equipe_ID"].ToString(), Image.FromFile("TeamsLogo/" + DataSet.Tables["Equipe"].Rows[i]["Logo"].ToString()), DataSet.Tables["Equipe"].Rows[i]["Team Name"].ToString(), DataSet.Tables["Equipe"].Rows[i]["City"].ToString(), DataSet.Tables["Equipe"].Rows[i]["Date Creation"].ToString(), DataSet.Tables["Equipe"].Rows[i]["Coach"].ToString(), DataSet.Tables["Equipe"].Rows[i]["Stade"]);
            }
            }catch(Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Refreshing Teams", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnDeleteGames_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                DBManager = new DBManager();
                DBManager.Query("delete From Equipe where Equipe_ID = @id");
                DBManager.cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DBManager.ExecuteQuery();
                DBManager.Close_Connection();
                btnRefresh.PerformClick();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Deleting Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (txtSearch.Text != "  Search...")
            {
                DBManager = new DBManager();
                DBManager.Query("Select_Search_Team @search");
                DBManager.cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                DataSet.Tables["Equipe"].Rows.Clear();
                DBManager.Refresh_DG(DataSet.Tables["Equipe"]);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < DataSet.Tables["Equipe"].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(DataSet.Tables["Equipe"].Rows[i]["Equipe_ID"].ToString(), Image.FromFile("TeamsLogo/" + DataSet.Tables["Equipe"].Rows[i]["Logo"].ToString()), DataSet.Tables["Equipe"].Rows[i]["Team Name"].ToString(), DataSet.Tables["Equipe"].Rows[i]["City"].ToString(), DataSet.Tables["Equipe"].Rows[i]["Date Creation"].ToString(), DataSet.Tables["Equipe"].Rows[i]["Coach"].ToString(), DataSet.Tables["Equipe"].Rows[i]["Stade"]);
                }
                DBManager.Close_Connection();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Searching Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            Graphic.selectLast(dataGridView1, Positionlabel);
        }
    }
}
