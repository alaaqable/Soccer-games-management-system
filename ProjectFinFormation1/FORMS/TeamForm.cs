using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectFinFormation1
{
    public partial class TeamForm : Form
    {
        int position;
        DBManager DBManager;
        Graphic_Class graphic = new Graphic_Class();
        DataSet DataSet;
        public TeamForm()
        {
            InitializeComponent();
        }
        public TeamForm(int position) : this()
        {
            this.position = position;
        }
        #region txtIDTeam
        private void txtIDTeam_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(txtIDTeam, "Entre the ID of the Team", "183, 28, 28");
        }

        private void txtIDTeam_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(txtIDTeam, "Entre the ID of the Team", "183, 28, 28");
        }
        #endregion
        #region TxtNameTeam
        private void TxtNameTeam_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtNameTeam, "Entre the Name of the Team", "183, 28, 28");
        }

        private void TxtNameTeam_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtNameTeam, "Entre the Name of the Team", "183, 28, 28");
        }
        #endregion
        #region TxtNameTeam
        private void TxtCityTeam_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtCityTeam, "Entre the City of the Team", "183, 28, 28");
        }

        private void TxtCityTeam_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtCityTeam, "Entre the City of the Team", "183, 28, 28");
        }
        #endregion
        #region TxtNameTeam
        private void TxtTeamCoach_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtTeamCoach, "Entre the Coach Name", "183, 28, 28");
        }

        private void TxtTeamCoach_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtTeamCoach, "Entre the Coach Name", "183, 28, 28");
        }
        #endregion

        private void ClosePlayerForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddTeam_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager = new DBManager();
                DBManager.Query("Insert Into Equipe Values(@id,@nom,@ville,@date,@entraineur,@logo,@stade)");
                DBManager.cmd.Parameters.AddWithValue("@id", txtIDTeam.Text);
                DBManager.cmd.Parameters.AddWithValue("@nom", TxtNameTeam.Text);
                DBManager.cmd.Parameters.AddWithValue("@ville", TxtCityTeam.Text);
                DBManager.cmd.Parameters.AddWithValue("@date", DtpTeam.Value);
                DBManager.cmd.Parameters.AddWithValue("@entraineur", TxtTeamCoach.Text);
                DBManager.cmd.Parameters.AddWithValue("@logo", Path.GetFileNameWithoutExtension(PBLogo.ImageLocation) + ".png");
                DBManager.cmd.Parameters.AddWithValue("@stade", comboTeamStade.SelectedValue);
                DBManager.ExecuteQuery();
                MessageBox.Show("Your data is Added successfuly", "Adding Teams", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBManager.Close_Connection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Adding Teams", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TeamForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet = new DataSet();
                DBManager = new DBManager();
                DBManager.Query("Select * from Stade");
                DataSet = DBManager.Fill_DS("Stade");
                DBManager.Fill_Combobox(DataSet.Tables["Stade"],comboTeamStade, "Nom_Stade", "Stade_ID");
                if (buttonEditTeam.Enabled == true)
                {
                    DBManager.Query("Select * from Equipe");
                    DataSet = DBManager.Fill_DS("Equipe");
                    //Filling from other form
                    txtIDTeam.Text = DataSet.Tables["Equipe"].Rows[this.position]["Equipe_ID"].ToString();
                    PBLogo.ImageLocation = "TeamsLogo/" + DataSet.Tables["Equipe"].Rows[this.position]["Logo"].ToString();
                    TxtNameTeam.Text = DataSet.Tables["Equipe"].Rows[this.position]["Nom_Equipe"].ToString();
                    TxtCityTeam.Text = DataSet.Tables["Equipe"].Rows[this.position]["Ville"].ToString();
                    DtpTeam.Text = DataSet.Tables["Equipe"].Rows[this.position]["YearCreation"].ToString();
                    TxtTeamCoach.Text = DataSet.Tables["Equipe"].Rows[this.position]["Entraineur_Nom"].ToString();
                    comboTeamStade.SelectedValue = DataSet.Tables["Equipe"].Rows[this.position]["Stade_ID"];
                }

                DBManager.Close_Connection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Error Teams Form Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void PBLogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ".png|*.PNG";
            openFileDialog1.FileName = "";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PBLogo.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void buttonEditTeam_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager = new DBManager();
                DBManager.Query("update Equipe set Nom_Equipe=@nom,Ville = @ville,YearCreation = @date,Entraineur_Nom = @entraineur,Logo=@logo,Stade_ID = @stade where Equipe_ID = @id");
                DBManager.cmd.Parameters.AddWithValue("@id", txtIDTeam.Text);
                DBManager.cmd.Parameters.AddWithValue("@nom", TxtNameTeam.Text);
                DBManager.cmd.Parameters.AddWithValue("@ville", TxtCityTeam.Text);
                DBManager.cmd.Parameters.AddWithValue("@date", DtpTeam.Value);
                DBManager.cmd.Parameters.AddWithValue("@entraineur", TxtTeamCoach.Text);
                DBManager.cmd.Parameters.AddWithValue("@logo", Path.GetFileNameWithoutExtension(PBLogo.ImageLocation) + ".png");
                DBManager.cmd.Parameters.AddWithValue("@stade", comboTeamStade.SelectedValue);
                DBManager.ExecuteQuery();
                MessageBox.Show("Your data is Updated successfuly", "Updating Teams", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBManager.Close_Connection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Editing Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
