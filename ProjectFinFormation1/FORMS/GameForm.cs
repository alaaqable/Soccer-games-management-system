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
    public partial class GameForm : Form
    {
        int position;
        DBManager DBManager;
        DataSet dataSet = new DataSet();
        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(int position) : this()
        {
            this.position = position;
        }
        private void CloseGameForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            try
            {
            DBManager = new DBManager();
            DBManager.Query("select * from equipe");
            dataSet = DBManager.Fill_DS("home");
            DBManager.Fill_Combobox(dataSet.Tables["home"], comboTeamHome, "Nom_Equipe", "Equipe_ID");

            DBManager.Query("select * from equipe");
            dataSet = DBManager.Fill_DS("away");
            DBManager.Fill_Combobox(dataSet.Tables["away"], comboTeamAway, "Nom_Equipe", "Equipe_ID");

            DBManager.Query("select * from Referee");
            dataSet = DBManager.Fill_DS("Referee");
            DBManager.Fill_Combobox(dataSet.Tables["Referee"], comboReferee, "Nom", "CIN_Referee");

            DBManager.Query("select * from Stade");
            dataSet = DBManager.Fill_DS("Stade");
            DBManager.Fill_Combobox(dataSet.Tables["Stade"], comboStaduim, "Nom_Stade", "Stade_ID");

            if (buttonEditGame.Enabled == true)
            {
                DBManager.Query("select * from matche");
                dataSet = DBManager.Fill_DS("matche");
                txtID.Text = dataSet.Tables["matche"].Rows[position]["Match_ID"].ToString();
                txtdateofgame.Text = dataSet.Tables["matche"].Rows[position]["Date_Matche"].ToString();
                MTxtTimeGame.Text = dataSet.Tables["matche"].Rows[position]["Heure_Matche"].ToString();
                comboReferee.SelectedValue = dataSet.Tables["matche"].Rows[position]["CIN_Referee"];
                comboStaduim.SelectedValue = dataSet.Tables["matche"].Rows[position]["Stade_ID"];
                DBManager.Query("select * from Match_Equipe where Match_ID=@id");
                DBManager.cmd.Parameters.AddWithValue("@id", dataSet.Tables["matche"].Rows[position]["Match_ID"].ToString());
                dataSet = DBManager.Fill_DS("Match_Equipe");
                comboTeamHome.SelectedValue = dataSet.Tables["Match_Equipe"].Rows[0]["Eq_Home_ID"];
                comboTeamAway.SelectedValue = dataSet.Tables["Match_Equipe"].Rows[0]["Eq_Away_ID"];
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"GameForm Load Exeption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void ButtonAddGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboTeamHome.Text != comboTeamAway.Text) {
                    DBManager = new DBManager();
                    DBManager.Query("insert into Matche values (@id,@date,@heure,@stade,@referee)");
                    DBManager.cmd.Parameters.AddWithValue("@id", txtID.Text);
                    DBManager.cmd.Parameters.AddWithValue("@date", txtdateofgame.Value);
                    DBManager.cmd.Parameters.AddWithValue("@heure", MTxtTimeGame.Text);
                    DBManager.cmd.Parameters.AddWithValue("@stade", comboStaduim.SelectedValue);
                    DBManager.cmd.Parameters.AddWithValue("@referee", comboReferee.SelectedValue);
                    DBManager.ExecuteQuery();

                    DBManager.Query("insert into Match_Equipe values (@home,@away,@id)");
                    DBManager.cmd.Parameters.AddWithValue("@id", txtID.Text);
                    DBManager.cmd.Parameters.AddWithValue("@home", comboTeamHome.SelectedValue);
                    DBManager.cmd.Parameters.AddWithValue("@away", comboTeamAway.SelectedValue);
                    DBManager.ExecuteQuery();

                    MessageBox.Show("Your data is Added successfuly", "Adding Games", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBManager.Close_Connection();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("home team and away team can't be the same", "Same team Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Adding Games", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditGame_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager = new DBManager();
                DBManager.Query("update Matche Set Date_Matche=@date,Heure_Matche=@heure,Stade_ID=@stade,CIN_Referee=@referee where Match_ID=@id");
                DBManager.cmd.Parameters.AddWithValue("@id", txtID.Text);
                DBManager.cmd.Parameters.AddWithValue("@date", txtdateofgame.Value);
                DBManager.cmd.Parameters.AddWithValue("@heure", MTxtTimeGame.Text);
                DBManager.cmd.Parameters.AddWithValue("@stade", comboStaduim.SelectedValue);
                DBManager.cmd.Parameters.AddWithValue("@referee", comboReferee.SelectedValue);
                DBManager.ExecuteQuery();
                DBManager.Query("update Match_Equipe Set Eq_Home_ID=@home,Eq_Away_ID=@away where Match_ID=@id ");
                DBManager.cmd.Parameters.AddWithValue("@id", txtID.Text);
                DBManager.cmd.Parameters.AddWithValue("@home", comboTeamHome.SelectedValue);
                DBManager.cmd.Parameters.AddWithValue("@away", comboTeamAway.SelectedValue);
                DBManager.ExecuteQuery();

                MessageBox.Show("Your data is Updated successfuly", "Updating Games", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBManager.Close_Connection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Editing Games", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
