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
    public partial class PlayerForm : Form
    {
        int position;
        DBManager DBManager;
        DataSet dataSet = new DataSet();
        Graphic_Class graphic = new Graphic_Class();
        public PlayerForm()
        {
            InitializeComponent();
        }
        public PlayerForm(int position) : this()
        {
            this.position = position;
        }
        private void ClosePlayerForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region txtCIN
        private void txtCIN_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(txtCIN, "Entre the CIN of the Player", "21, 101, 192");
        }
        
        private void txtCIN_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(txtCIN, "Entre the CIN of the Player", "21, 101, 192");
        }
        #endregion
        #region TxtLastName
        private void TxtLastName_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtLastName, "Entre the LastName of the Player", "21, 101, 192");
        }

        private void TxtLastName_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtLastName, "Entre the LastName of the Player", "21, 101, 192");
        }
        #endregion
        #region TxtFirstName
        private void TxtFirstName_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtFirstName, "Entre the FirstName of the Player", "21, 101, 192");
        }

        private void TxtFirstName_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtFirstName, "Entre the FirstName of the Player", "21, 101, 192");
        }
        #endregion
        #region TxtPosition
        private void TxtPosition_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtPosition, "Entre the Position of the Player", "21, 101, 192");
        }

        private void TxtPosition_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtPosition, "Entre the Position of the Player", "21, 101, 192");
        }
        #endregion
        #region TxtNumbre
        private void TxtNumbre_Enter(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtNumbre, "Entre the Numbre of the Player", "21, 101, 192");
        }

        private void TxtNumbre_Leave(object sender, EventArgs e)
        {
            graphic.TextboxControler(TxtNumbre, "Entre the Numbre of the Player", "21, 101, 192");
        }
        #endregion

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            try
            {
            DBManager = new DBManager();
            DBManager.Query("select * from Equipe");
            dataSet = DBManager.Fill_DS("Equipe");
            DBManager.Fill_Combobox(dataSet.Tables["Equipe"], comboPlayerTeam, "Nom_Equipe", "Equipe_ID");

            if(ButtonEditPlayer.Enabled == true)
            {
                DBManager.Query("select * from Joueur");
                dataSet = DBManager.Fill_DS("Joueur");

                txtCIN.Text = dataSet.Tables["Joueur"].Rows[this.position]["CIN_Joueur"].ToString();
                TxtLastName.Text = dataSet.Tables["Joueur"].Rows[this.position]["Nom_Joueur"].ToString();
                TxtFirstName.Text = dataSet.Tables["Joueur"].Rows[this.position]["Prenom_Joueur"].ToString();
                TxtPosition.Text = dataSet.Tables["Joueur"].Rows[this.position]["Position"].ToString();
                TxtNumbre.Text = dataSet.Tables["Joueur"].Rows[this.position]["Numero"].ToString();
                Dtpplayer.Text = dataSet.Tables["Joueur"].Rows[this.position]["Date_Naissance"].ToString();
                comboPlayerTeam.SelectedValue = dataSet.Tables["Joueur"].Rows[this.position]["Equipe_ID"];
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "PlayerForm Load Exeption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DBManager.Close_Connection();
        }

        private void ButtonAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager = new DBManager();
                DBManager.Query("insert into Joueur values (@cin,@nom,@prenom,@position,@numero,@date,@eqid)");
                DBManager.cmd.Parameters.AddWithValue("@cin", txtCIN.Text);
                DBManager.cmd.Parameters.AddWithValue("@nom", TxtFirstName.Text);
                DBManager.cmd.Parameters.AddWithValue("@prenom", TxtLastName.Text);
                DBManager.cmd.Parameters.AddWithValue("@position", TxtPosition.Text);
                DBManager.cmd.Parameters.AddWithValue("@numero", TxtNumbre.Text);
                DBManager.cmd.Parameters.AddWithValue("@date", Dtpplayer.Value);
                DBManager.cmd.Parameters.AddWithValue("@eqid", comboPlayerTeam.SelectedValue);
                DBManager.ExecuteQuery();
                MessageBox.Show("Your data is Added successfuly", "Adding Players", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBManager.Close_Connection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Adding Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonEditPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager = new DBManager();
                DBManager.Query("update Joueur set Nom_Joueur=@nom,Prenom_Joueur = @prenom,Position = @position,Numero = @numero,Date_Naissance = @date,Equipe_ID = @eqid where CIN_Joueur = @cin");
                DBManager.cmd.Parameters.AddWithValue("@cin", txtCIN.Text);
                DBManager.cmd.Parameters.AddWithValue("@nom", TxtFirstName.Text);
                DBManager.cmd.Parameters.AddWithValue("@prenom", TxtLastName.Text);
                DBManager.cmd.Parameters.AddWithValue("@position", TxtPosition.Text);
                DBManager.cmd.Parameters.AddWithValue("@numero", TxtNumbre.Text);
                DBManager.cmd.Parameters.AddWithValue("@date", Dtpplayer.Value);
                DBManager.cmd.Parameters.AddWithValue("@eqid", comboPlayerTeam.SelectedValue);
                DBManager.ExecuteQuery();
                MessageBox.Show("Your data is Updated successfuly", "Updating Players", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBManager.Close_Connection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message, "Exception Editing Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
