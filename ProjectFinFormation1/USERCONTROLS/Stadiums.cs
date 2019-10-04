using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinFormation1.USERCONTROLS
{
    public partial class Stadiums : UserControl
    {
        DBManager DBManager;
        StadiumForm StadiumForm;
        DataSet DataSet;
        Graphic_Class Graphic = new Graphic_Class();
        public Stadiums()
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
            try
            {
            StadiumForm = new StadiumForm();
            StadiumForm.buttonAddStadium.BringToFront();
            StadiumForm.buttonAddStadium.Enabled = true;
            //show the id of the entrie in the textbox
            if (dataGridView1.Rows.Count > 0)
            {
                StadiumForm.txtIDStadium.Text = (dataGridView1.Rows.Count + 1).ToString();
            }
            else
            {
                StadiumForm.txtIDStadium.Text = "1";
            }
            StadiumForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Adding Stadium", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditGames_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                int Index = dataGridView1.SelectedCells[0].OwningRow.Index;
                StadiumForm = new StadiumForm(Index);
                StadiumForm.buttonEditStadium.BringToFront();
                StadiumForm.txtIDStadium.Enabled = false;
                StadiumForm.buttonEditStadium.Enabled = true;
                StadiumForm.ShowDialog();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error Editing Stadiums", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Stadiums_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet = new DataSet();
                DBManager = new DBManager();
                DBManager.Query("Select Stade_ID as 'Stadium ID',Nom_Stade as 'Stadium Name',Ville_Stade as 'Stadium City' From Stade");
                DataSet = DBManager.Fill_DS("Stade");
                DBManager.Fill_DGV(DataSet.Tables["Stade"], dataGridView1);
                DBManager.Close_Connection();
                if (dataGridView1.Rows.Count > 0)
                {
                    Positionlabel.Text = (dataGridView1.SelectedCells[0].OwningRow.Index + 1).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Stadiums Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
            DataSet.Tables["Stade"].Rows.Clear();
            DBManager = new DBManager();
            DBManager.Query("Select Stade_ID as 'Stadium ID',Nom_Stade as 'Stadium Name',Ville_Stade as 'Stadium City' From Stade");
            DBManager.Refresh_DG(DataSet.Tables["Stade"]);
            DBManager.Fill_DGV(DataSet.Tables["Stade"], dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Refresh DataGridView Stadiums", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteGames_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                DBManager = new DBManager();
                DBManager.Query("delete From Stade where Stade_ID = @id");
                DBManager.cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DBManager.ExecuteQuery();
                DBManager.Close_Connection();
                btnRefresh.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Deleting Stadiums", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (txtSearch.Text != "  Search...")
            {
                DBManager = new DBManager();
                DBManager.Query("Select Stade_ID as 'Stadium ID',Nom_Stade as 'Stadium Name',Ville_Stade as 'Stadium City' From Stade where Nom_Stade like @search+'%'");
                DBManager.cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                DataSet.Tables["Stade"].Rows.Clear();
                DBManager.Refresh_DG(DataSet.Tables["Stade"]);
                DBManager.Fill_DGV(DataSet.Tables["Stade"], dataGridView1);
                DBManager.Close_Connection();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Searching Stadiums", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
