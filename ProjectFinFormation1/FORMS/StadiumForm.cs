using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinFormation1
{
    public partial class StadiumForm : Form
    {
        int position;
        DBManager DBManager;
        Graphic_Class graphic = new Graphic_Class();
        DataSet dataSet = new DataSet();
        public StadiumForm()
        {
            InitializeComponent();
        }
        public StadiumForm(int position) : this()
        {
            this.position = position;
        }
        #region txtIDStadium

        private void txtIDStadium_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(txtIDStadium, "Entre the ID of the Stadium", "216, 67, 21");
        }

        private void txtIDStadium_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(txtIDStadium, "Entre the ID of the Stadium", "216, 67, 21");
        }
        #endregion
        #region TxtNameStadium
        private void TxtNameStadium_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtNameStadium, "Entre the Name of the Stadium", "216, 67, 21");
        }

        private void TxtNameStadium_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtNameStadium, "Entre the Name of the Stadium", "216, 67, 21");
        }
        #endregion
        #region TxtCityStadium
        private void TxtCityStadium_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtCityStadium, "Entre the City of the Stadium", "216, 67, 21");
        }

        private void TxtCityStadium_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtCityStadium, "Entre the City of the Stadium", "216, 67, 21");
        }
        #endregion

        private void CloseStadiumForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddStadium_Click(object sender, EventArgs e)
        {

            try
            {
                DBManager = new DBManager();
                DBManager.Query("Insert Into Stade Values(@id,@StadeName,@CityStade)");
                DBManager.cmd.Parameters.AddWithValue("@id", txtIDStadium.Text);
                DBManager.cmd.Parameters.AddWithValue("@StadeName", TxtNameStadium.Text);
                DBManager.cmd.Parameters.AddWithValue("@CityStade", TxtCityStadium.Text);
                DBManager.ExecuteQuery();
                MessageBox.Show("Your data is Added successfuly", "Adding Stadiums", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBManager.Close_Connection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n"+ex.Message,"Exception Adding Stadium",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void StadiumForm_Load(object sender, EventArgs e)
        {
            try
            {
            if (buttonEditStadium.Enabled == true)
            {
                DBManager = new DBManager();
                DBManager.Query("select * from Stade");
                dataSet = DBManager.Fill_DS("Stade");
                txtIDStadium.Text = dataSet.Tables["Stade"].Rows[this.position]["Stade_ID"].ToString();
                TxtNameStadium.Text = dataSet.Tables["Stade"].Rows[this.position]["Nom_Stade"].ToString();
                TxtCityStadium.Text = dataSet.Tables["Stade"].Rows[this.position]["Ville_Stade"].ToString();

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception in StadiumForm Load", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEditStadium_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager = new DBManager();
                DBManager.Query("update Stade set Nom_Stade=@StadeName,Ville_Stade = @CityStade where Stade_ID = @id");
                DBManager.cmd.Parameters.AddWithValue("@id", txtIDStadium.Text);
                DBManager.cmd.Parameters.AddWithValue("@StadeName", TxtNameStadium.Text);
                DBManager.cmd.Parameters.AddWithValue("@CityStade", TxtCityStadium.Text);
                DBManager.ExecuteQuery();
                DBManager.Close_Connection();
                MessageBox.Show("Your data is Updated successfuly", "Updating Stadiums", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Editing Stadiums", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
