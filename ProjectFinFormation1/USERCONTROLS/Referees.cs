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
    public partial class Referees : UserControl
    {
        DBManager DBManager;
        RefereeForm RefereeForm;
        DataSet DataSet;
        Graphic_Class Graphic = new Graphic_Class();
        public Referees()
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
            RefereeForm = new RefereeForm();
            RefereeForm.buttonAddReferee.BringToFront();
            RefereeForm.buttonAddReferee.Enabled = true;
            RefereeForm.ShowDialog();
            
        }

        private void btnEditGames_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                int Index = dataGridView1.SelectedCells[0].OwningRow.Index;
                RefereeForm = new RefereeForm(Index);
                RefereeForm.buttonEditReferee.BringToFront();
                RefereeForm.txtCinReferee.Enabled = false;
                RefereeForm.buttonEditReferee.Enabled = true;
                RefereeForm.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error Editing Referees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Referees_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet = new DataSet();
                DBManager = new DBManager();
                DBManager.Query("Select CIN_Referee as 'CIN Referee',Nom as 'Nom Referee' From Referee");
                DataSet = DBManager.Fill_DS("Referee");
                DBManager.Fill_DGV(DataSet.Tables["Referee"], dataGridView1);
                DBManager.Close_Connection();
                if (dataGridView1.Rows.Count > 0)
                {
                    Positionlabel.Text = (dataGridView1.SelectedCells[0].OwningRow.Index + 1).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Referee Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
            DataSet.Tables["Referee"].Rows.Clear();
            DBManager = new DBManager();
            DBManager.Query("Select CIN_Referee as 'CIN Referee',Nom as 'Nom Referee' From Referee");
            DBManager.Refresh_DG(DataSet.Tables["Referee"]);
            DBManager.Fill_DGV(DataSet.Tables["Referee"], dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Refresh DataGridView Referee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteGames_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                DBManager = new DBManager();
                DBManager.Query("delete From Referee where CIN_Referee = @cin");
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
                DBManager.Query("Select CIN_Referee as 'CIN Referee',Nom as 'Nom Referee' From Referee where Nom like @search + '%' ");
                DBManager.cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                DataSet.Tables["Referee"].Rows.Clear();
                DBManager.Refresh_DG(DataSet.Tables["Referee"]);
                DBManager.Fill_DGV(DataSet.Tables["Referee"], dataGridView1);
                DBManager.Close_Connection();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Referee Searching", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
