using System;
using System.Drawing;
using System.Windows.Forms;
using BunifuAnimatorNS;

namespace ProjectFinFormation1
{
    public class Graphic_Class
    {

        //to change the hover color while button is selected 
        public void Hover_Color(string color,Button selectedbutton,Button button1,Button button2, Button button3, Button button4, Button button5)
        {
            try
            {
            selectedbutton.BackColor = ColorTranslator.FromHtml(color);
            button1.BackColor = ColorTranslator.FromHtml("#212121");
            button2.BackColor = ColorTranslator.FromHtml("#212121");
            button3.BackColor = ColorTranslator.FromHtml("#212121");
            button4.BackColor = ColorTranslator.FromHtml("#212121");
            button5.BackColor = ColorTranslator.FromHtml("#212121");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Change Hover Color Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //send to back and bring to front user control 
        public void Back_Front(UserControl FrontConrol,UserControl control1,UserControl control2, UserControl control3, UserControl control4, UserControl control5, Panel panel)
        {
            try
            {
            panel.Controls.Remove(control1);
            panel.Controls.Remove(control2);
            panel.Controls.Remove(control3);
            panel.Controls.Remove(control4);
            panel.Controls.Remove(control5);
            panel.Controls.Add(FrontConrol);
            FrontConrol.Dock = DockStyle.Fill;
            FrontConrol.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BringToFront/SendToBack UserControls Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //user control animation (Sliding horizantally)
        public void Users_Animation(UserControl control)
        {
            try
            {
            control.Visible = false;
            BunifuTransition transition = new BunifuTransition();
            transition.AnimationType = AnimationType.HorizSlide;
            transition.TimeStep = 0.03F;
            transition.ShowSync(control);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Animation UserControls Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //To control Menu Panel
        public void MenuDrager(Panel panel)
        {
            try
            {
            if (panel.Width == 200)
            {
                panel.Width = 0;

            }
            else if (panel.Width == 0)
            {
                panel.Width = 200;
                panel.BringToFront();
                
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MenuDrager Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //to change TextBox color and forecolor
        public void TextboxControler(Bunifu.Framework.UI.BunifuMetroTextbox textBox,string text,string BorderColor)
        {
            try
            {
            if(textBox.Text == text)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.White;
                textBox.BorderColorIdle = ColorTranslator.FromHtml(BorderColor);

            }else if (textBox.Text == "")
            {
                textBox.Text = text;
                textBox.ForeColor = ColorTranslator.FromHtml("192, 0, 0");
                textBox.BorderColorIdle = ColorTranslator.FromHtml("192, 0, 0");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TextboxControler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 
        //to select the first item in the DataGridView
        public void selectFirst(DataGridView dataGridView,Label label)
        {
            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[0].Selected = true;
                label.Text = (dataGridView.SelectedCells[0].OwningRow.Index + 1).ToString() + "/" + dataGridView.Rows.Count.ToString();
            }
        }
        //to select the Previous item in the DataGridView
        public void selectPrevious(DataGridView dataGridView, Label label)
        {
            if (dataGridView.Rows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].OwningRow.Index;
                if (dataGridView.SelectedCells[0].OwningRow.Index > 0)
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[rowIndex - 1].Selected = true;
                    label.Text = (dataGridView.SelectedCells[0].OwningRow.Index + 1).ToString() + "/" + dataGridView.Rows.Count.ToString();
                }
            }
        }
        //to select the Next item in the DataGridView
        public void selectNext(DataGridView dataGridView, Label label)
        {
            if (dataGridView.Rows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].OwningRow.Index;
                if (dataGridView.SelectedCells[0].OwningRow.Index < dataGridView.Rows.Count - 1)
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[rowIndex + 1].Selected = true;
                    label.Text = (dataGridView.SelectedCells[0].OwningRow.Index + 1).ToString() + "/" + dataGridView.Rows.Count.ToString();
                }
            }
        }
        //to select the Last item in the DataGridView
        public void selectLast(DataGridView dataGridView,Label label)
        {
            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[dataGridView.Rows.Count - 1].Selected = true;
                label.Text = (dataGridView.SelectedCells[0].OwningRow.Index + 1).ToString() + "/" + dataGridView.Rows.Count.ToString();
            }
        }
        public void UserPanelControler(Panel panel)
        {
            
            if(panel.Height == 0)
            {
                panel.Height = 142;
                panel.BringToFront();
            }
            else
            {
                panel.Height = 0;
            }
        }
    }
}
