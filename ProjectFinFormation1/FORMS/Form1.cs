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
    public partial class Form1 : Form
    {
        Home home1;
        Games games1;
        Teams teams1;
        FORMS.Players players1;
        USERCONTROLS.Referees referees1;
        USERCONTROLS.Stadiums stadiums1;

        
        bool HomeIsopen = false;
        bool GameIsopen = false;
        bool TeamIsopen = false;
        bool PlayerIsopen = false;
        bool StadiumIsopen = false;
        bool RefereeIsopen = false;
        string CIN;
        string Name;
        string Email;
        Graphic_Class graphic = new Graphic_Class();
        DBManager DBManager;
        DataSet dsteam = new DataSet();
        DataSet dsmatch = new DataSet();
        public Form1()
        {
            InitializeComponent();
            btnhome.BackColor = ColorTranslator.FromHtml("#424242");
        }
        public Form1(string CIN,string Name,string Email) : this()
        {
            this.CIN = CIN;
            this.Name = Name;
            this.Email = Email;
            lblCIN.Text = this.CIN;
            lblName.Text = this.Name;
            lblEmail.Text = this.Email;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //btnmenu
        private void btnmenu_Click(object sender, EventArgs e)
        {
            panelcontrols.SendToBack();
            graphic.MenuDrager(Menupanel);
        }
        //btnGamer
        private void btnGamer_Click(object sender, EventArgs e)
        {
            games1 = new Games();
            
            if (GameIsopen == false)
            {
                graphic.MenuDrager(Menupanel);
                graphic.Back_Front(games1,home1,teams1,referees1,players1,stadiums1,panelcontrols);
                graphic.Hover_Color("74, 20, 140", btnGamer, btnhome, btnPlayer, btnReferee, btnStadium, btnTeam);
                graphic.Users_Animation(games1);
                GameIsopen = true;
                HomeIsopen = false;
                TeamIsopen = false;
                PlayerIsopen = false;
                StadiumIsopen = false;
                RefereeIsopen = false;
            }
        }
        //btnhome
        private void btnhome_Click(object sender, EventArgs e)
        {

            if (HomeIsopen == false)
            {
                graphic.MenuDrager(Menupanel);
                RandomControls();
                graphic.Back_Front(home1, games1, teams1, players1, stadiums1, referees1, panelcontrols);
                graphic.Hover_Color("#424242", btnhome, btnGamer, btnPlayer, btnReferee, btnStadium, btnTeam);
                graphic.Users_Animation(home1);
                GameIsopen = false;
                HomeIsopen = true;
                TeamIsopen = false;
                PlayerIsopen = false;
                StadiumIsopen = false;
                RefereeIsopen = false;
                DBManager = new DBManager();
                DBManager.Chart_Filler(home1.chart1);
                DBManager.Label_Filler(home1.lblCountGame, home1.lblCountPlayer, home1.lblCountTeam, home1.lblCountStadium, home1.lblCountReferee);

            }
        }
        //btnTeam
        private void btnTeam_Click(object sender, EventArgs e)
        {
            if (TeamIsopen == false)
            {
                teams1 = new Teams();
                graphic.MenuDrager(Menupanel);
                graphic.Back_Front(teams1, games1, home1, referees1, players1, stadiums1, panelcontrols);
                graphic.Hover_Color("183, 28, 28", btnTeam, btnGamer, btnPlayer, btnReferee, btnStadium, btnhome);
                graphic.Users_Animation(teams1);
                GameIsopen = false;
                HomeIsopen = false;
                TeamIsopen = true;
                PlayerIsopen = false;
                StadiumIsopen = false;
                RefereeIsopen = false;
            }
        }
        //btnPlayer
        private void btnPlayer_Click(object sender, EventArgs e)
        {
            if (PlayerIsopen == false)
            {
                players1 = new FORMS.Players();
                graphic.MenuDrager(Menupanel);
                graphic.Back_Front(players1, games1, home1, teams1, referees1, stadiums1, panelcontrols);
                graphic.Hover_Color("21, 101, 192", btnPlayer, btnGamer, btnhome, btnReferee, btnStadium, btnTeam);
                graphic.Users_Animation(players1);
                GameIsopen = false;
                HomeIsopen = false;
                TeamIsopen = false;
                PlayerIsopen = true;
                StadiumIsopen = false;
                RefereeIsopen = false;
            }
        }
        //btnStadium
        private void btnStadium_Click(object sender, EventArgs e)
        {
            if (StadiumIsopen == false)
            {
                stadiums1 = new USERCONTROLS.Stadiums();
                graphic.MenuDrager(Menupanel);
                graphic.Back_Front(stadiums1, players1, games1, home1, teams1, referees1, panelcontrols);
                graphic.Hover_Color("216, 67, 21", btnStadium, btnGamer, btnPlayer, btnReferee, btnhome, btnTeam);
                graphic.Users_Animation(stadiums1);
                GameIsopen = false;
                HomeIsopen = false;
                TeamIsopen = false;
                PlayerIsopen = false;
                StadiumIsopen = true;
                RefereeIsopen = false;
            }
        }
        //btnReferee
        private void btnReferee_Click(object sender, EventArgs e)
        {
            if (RefereeIsopen == false)
            {
                referees1 = new USERCONTROLS.Referees();
                graphic.MenuDrager(Menupanel);
                graphic.Back_Front(referees1, players1, games1, home1, teams1, stadiums1, panelcontrols);
                graphic.Hover_Color("46, 125, 50", btnReferee, btnGamer, btnPlayer, btnhome, btnStadium, btnTeam);
                graphic.Users_Animation(referees1);
                GameIsopen = false;
                HomeIsopen = false;
                TeamIsopen = false;
                PlayerIsopen = false;
                StadiumIsopen = false;
                RefereeIsopen = true;
            }
        }
        //btnminimze
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void RandomControls()
        {
            //fill teams
            //DBManager = new DBManager();
            //DBManager.Query("select m.Logo,m.Nom_Equipe,YEAR(m.YearCreation) as 'YearCreation',m.Ville,m.Entraineur_Nom,s.Nom_Stade from Equipe m inner join Stade s on s.Stade_ID=m.Stade_ID");
            //dsteam = DBManager.Fill_DS("randomTeam");
            //DBManager.Close_Connection();
            ////fill games
            //DBManager = new DBManager();
            //DBManager.Query("select m.Match_ID,eqh.Logo as'logoHome',eqh.Nom_Equipe,eqa.Nom_Equipe,eqa.Logo as 'logoAway',DATENAME(WEEKDAY,m.Date_Matche) + ','+ DATENAME(MONTH,m.Date_Matche) +' '+ CONVERT(varchar,DAY(m.Date_Matche)) + ','+CONVERT(varchar,Year(m.Date_Matche)) as'date', m.Heure_Matche, s.Nom_Stade " +
            //   "from Match_Equipe me inner join Matche m on me.Match_ID=m.Match_ID inner join Equipe eqa on eqa.Equipe_ID=me.Eq_Away_ID inner join Equipe eqh on me.Eq_Home_ID=eqh.Equipe_ID inner join Stade s on m.Stade_ID=s.Stade_ID");
            //dsmatch = DBManager.Fill_DS("randomMatch");
            //DBManager.Close_Connection();
            //random
            //if(dsmatch.Tables["randomMatch"].Rows.Count-1 > 0)
            //{
           
            //
            //home1 = new Home(, );
            //}
            home1 = new Home();
            home1.RandomGame();
            home1.RandomTeam();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomControls();
            graphic.Back_Front(home1, games1, teams1, players1, stadiums1, referees1, panelcontrols);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            graphic.UserPanelControler(panelUserInfo);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm LF = new LogInForm();
            LF.Show();
        }
    }
}
