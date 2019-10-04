using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinFormation1.FORMS
{
    public partial class Players : UserControl
    {
        DBManager DBManager;
        PlayerForm playerForm;
        public DataSet dataSet = new DataSet();
        Graphic_Class Graphic = new Graphic_Class();
        public Players()
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
            playerForm = new PlayerForm();
            playerForm.ButtonAddPlayer.BringToFront();
            playerForm.ButtonAddPlayer.Enabled = true;
            playerForm.ShowDialog();
        }

        private void btnEditGames_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                int Index = dataGridView1.SelectedCells[0].OwningRow.Index;
                playerForm = new PlayerForm(Index);
                playerForm.ButtonEditPlayer.BringToFront();
                playerForm.txtCIN.Enabled = false;
                playerForm.ButtonEditPlayer.Enabled = true;
                playerForm.ShowDialog();
            }

        }

        private void Players_Load(object sender, EventArgs e)
        {
            try
            {
            DBManager = new DBManager();
            DBManager.Query("Select_Players");
            dataSet = DBManager.Fill_DS("Joueur");
            DBManager.Fill_DGV(dataSet.Tables["Joueur"],dataGridView1);
            DBManager.Close_Connection();
            if (dataGridView1.Rows.Count  > 0)
            {
                Positionlabel.Text = (dataGridView1.SelectedCells[0].OwningRow.Index + 1).ToString() + "/" + dataGridView1.Rows.Count.ToString();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Player_Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
            dataSet.Tables["Joueur"].Rows.Clear();
            DBManager = new DBManager();
            DBManager.Query("Select_Players");
            DBManager.Refresh_DG(dataSet.Tables["Joueur"]);
            DBManager.Fill_DGV(dataSet.Tables["Joueur"],dataGridView1);
            DBManager.Close_Connection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "btnRefresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteGames_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    DBManager = new DBManager();
                    DBManager.Query("delete From Joueur where CIN_Joueur = @cin");
                    DBManager.cmd.Parameters.AddWithValue("@cin", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    DBManager.ExecuteQuery();
                    DBManager.Close_Connection();
                    btnRefresh.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Deleting Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (txtSearch.Text != "  Search...")
            {
                DBManager = new DBManager();
                DBManager.Query("Select_Search_Player @search");
                DBManager.cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                dataSet.Tables["Joueur"].Rows.Clear();
                DBManager.Refresh_DG(dataSet.Tables["Joueur"]);
                DBManager.Fill_DGV(dataSet.Tables["Joueur"], dataGridView1);
                DBManager.Close_Connection();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Searching Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
