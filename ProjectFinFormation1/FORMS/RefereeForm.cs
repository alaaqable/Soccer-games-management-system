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
    public partial class RefereeForm : Form
    {
        int position;
        DBManager DBManager;
        Graphic_Class graphic = new Graphic_Class();
        DataSet dataSet = new DataSet();
        public RefereeForm()
        {
            InitializeComponent();
        }
        public RefereeForm(int position) : this()
        {
            this.position = position;
        }
        private void CloseRefereeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region txtCinReferee
        private void txtCinReferee_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(txtCinReferee, "Entre the CIN of the Referee", "46, 125, 50");
        }

        private void txtCinReferee_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(txtCinReferee, "Entre the CIN of the Referee", "46, 125, 50");
        }
        #endregion
        #region TxtNameReferee
        private void TxtNameReferee_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtNameReferee, "Entre the Name of the Referee", "46, 125, 50");
        }

        private void TxtNameReferee_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtNameReferee, "Entre the Name of the Referee", "46, 125, 50");
        }
        #endregion

        private void buttonAddReferee_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager = new DBManager();
                DBManager.Query("Insert Into Referee Values(@CIN,@Name)");
                DBManager.cmd.Parameters.AddWithValue("@CIN", txtCinReferee.Text);
                DBManager.cmd.Parameters.AddWithValue("@Name", TxtNameReferee.Text);
                DBManager.ExecuteQuery();
                MessageBox.Show("Your data is Added successfuly", "Adding Referees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBManager.Close_Connection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Adding Referees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefereeForm_Load(object sender, EventArgs e)
        {
            try
            {
            if(buttonEditReferee.Enabled == true)
            {
                DBManager = new DBManager();
                DBManager.Query("select * from Referee");
                dataSet = DBManager.Fill_DS("Referee");
                DBManager.Close_Connection();

                txtCinReferee.Text = dataSet.Tables["Referee"].Rows[this.position]["CIN_Referee"].ToString();
                TxtNameReferee.Text = dataSet.Tables["Referee"].Rows[this.position]["Nom"].ToString();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception RefereeForm Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonEditReferee_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager = new DBManager();
                DBManager.Query("update Referee set Nom = @Name where CIN_Referee = @CIN");
                DBManager.cmd.Parameters.AddWithValue("@CIN", txtCinReferee.Text);
                DBManager.cmd.Parameters.AddWithValue("@Name", TxtNameReferee.Text);
                DBManager.ExecuteQuery();
                MessageBox.Show("Your data is Updated successfuly", "Updating Referees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBManager.Close_Connection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Editing Referees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
