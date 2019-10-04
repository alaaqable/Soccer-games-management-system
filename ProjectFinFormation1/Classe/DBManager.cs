using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using System;

namespace ProjectFinFormation1
{
    public class DBManager
    {
        //Declaration Variable
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet dataSet, dsChart;
        DataTable table = new DataTable();
        public SqlCommand cmd;
        //Constructors
        public DBManager()
        {
            try
            {
            connection = new SqlConnection(@"Data Source=.;Initial Catalog=GestionMatchDB;Integrated Security=True");
            connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //Method : Query
        public void Query(string QueryText)
        {
            try
            {
            cmd = new SqlCommand(QueryText, connection);

            }
            catch { }
        }
        //Method : FILL DATASET
        public DataSet Fill_DS(string Table_Name)
        {
            try
            {
            dataSet = new DataSet();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet, Table_Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fill DataSet Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataSet;
        }
        //Method : FOR EXECUTE QUERY
        public void ExecuteQuery()
        {
            try
            {
            cmd.ExecuteNonQuery();
            }catch { }
            
        }
        //Method : FOR CLOSE CONNECTION TO  DATABASE
        public void Close_Connection()
        {
            connection.Close();
        }
        //Method : TO FILL COMBOBOX
        public void Fill_Combobox(DataTable table, ComboBox comboBox, string Display_Member, string Value_Member)
        {
            try
            {
            comboBox.DisplayMember = Display_Member;
            comboBox.ValueMember = Value_Member;
            comboBox.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fill ComboBox Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Method : TO REFRESH DATAGRIDVIEW
        public void Refresh_DG(DataTable table)
        {
            try
            {
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Refresh DataGridView Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Method : FOR FILLING DATAGRIDVIEW
        public void Fill_DGV(DataTable table, DataGridView dataGridView)
        {
            try
            {
             dataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fill DataGridView Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Method : to fill Chart
        public void Chart_Filler(Chart chart)
        {
            try
            {
            ArrayList ChartX = new ArrayList();
            ArrayList ChartY = new ArrayList();
            dsChart = new DataSet();
            Query("select * from chart_filler");
            dsChart = Fill_DS("Chart");

            for (int i = 0; i < dsChart.Tables["Chart"].Rows.Count; i++)
            {
                ChartX.Add(dsChart.Tables["Chart"].Rows[i][0].ToString());
                ChartY.Add(int.Parse(dsChart.Tables["Chart"].Rows[i][1].ToString()));
            }
            chart.Series[0].Points.DataBindXY(ChartX, ChartY);
             chart.Series[0].Points[0].Color = ColorTranslator.FromHtml("#B61AB4");
             chart.Series[0].Points[1].Color = ColorTranslator.FromHtml("#87ACED");
             chart.Series[0].Points[2].Color = ColorTranslator.FromHtml("#13A453");
             chart.Series[0].Points[3].Color = ColorTranslator.FromHtml("#FF7C00");
             chart.Series[0].Points[4].Color = ColorTranslator.FromHtml("#C93E22");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fill Chart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Method : to fill labels in home user control with the count
        public void Label_Filler(Label Game,Label Player,Label Team,Label Stadium,Label Referee)
        {
            try
            {
            Game.Text = dsChart.Tables["Chart"].Rows[0][1].ToString();
            Player.Text = dsChart.Tables["Chart"].Rows[1][1].ToString();
            Referee.Text = dsChart.Tables["Chart"].Rows[2][1].ToString();
            Stadium.Text = dsChart.Tables["Chart"].Rows[3][1].ToString();
            Team.Text = dsChart.Tables["Chart"].Rows[4][1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fill Label of Counts Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
    
}
