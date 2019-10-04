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
    public partial class Home : UserControl
    {
        DBManager DBManager;
        DataSet dsTeam = new DataSet();
        DataSet dsMatch = new DataSet();
        int positionGame;
        int positionTeam;
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            RandomGame();
            RandomTeam();
            DBManager = new DBManager();
            DBManager.Chart_Filler(chart1);
            DBManager.Label_Filler(lblCountGame, lblCountPlayer, lblCountTeam, lblCountStadium, lblCountReferee);
        }

        public void RandomGame()
        {
            try
            {
                DBManager = new DBManager();
                DBManager.Query("Random_Games");
                dsMatch = DBManager.Fill_DS("randomMatch");
                DBManager.Close_Connection();
                Random randomMatch = new Random();
                positionGame = randomMatch.Next(0, dsMatch.Tables["randomMatch"].Rows.Count - 1);
                pictureBoxHome.ImageLocation = "TeamsLogo/" + dsMatch.Tables["randomMatch"].Rows[positionGame]["logoHome"].ToString();
                pictureBoxAway.ImageLocation = "TeamsLogo/" + dsMatch.Tables["randomMatch"].Rows[positionGame]["logoAway"].ToString();
                labelTime.Text = dsMatch.Tables["randomMatch"].Rows[positionGame]["Heure_Matche"].ToString();
                labelDate.Text = dsMatch.Tables["randomMatch"].Rows[positionGame]["date"].ToString();
                labelStadium.Text = dsMatch.Tables["randomMatch"].Rows[positionGame]["Nom_Stade"].ToString();
            }
            catch {}
        }
        public void RandomTeam()
        {
            try
            {
                DBManager manager = new DBManager();
                manager.Query("Random_Teams");
                dsTeam = manager.Fill_DS("RandomTeam");
                Random randomTeam = new Random();
                positionTeam = randomTeam.Next(0, dsTeam.Tables["randomTeam"].Rows.Count - 1);
                pictureBoxTeam.ImageLocation = "TeamsLogo/" + dsTeam.Tables["RandomTeam"].Rows[positionTeam]["Logo"].ToString();
                TeamName.Text = dsTeam.Tables["RandomTeam"].Rows[positionTeam]["Nom_Equipe"].ToString();
                labelyear.Text = dsTeam.Tables["RandomTeam"].Rows[positionTeam]["YearCreation"].ToString();
                labelVille.Text = dsTeam.Tables["RandomTeam"].Rows[positionTeam]["Ville"].ToString();
                labelCoach.Text = dsTeam.Tables["RandomTeam"].Rows[positionTeam]["Entraineur_Nom"].ToString();
                labelStade.Text = dsTeam.Tables["RandomTeam"].Rows[positionTeam]["Nom_Stade"].ToString();
            }
            catch{}
        }
    }
}
