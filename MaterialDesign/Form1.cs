using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Data.SQLite;
using LiveCharts;

namespace MaterialDesign
{
    public partial class Form1 : MaterialForm
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\backend\progressDatabase.db");

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        protected void RePaint()
        {
            GraphicsPath graphicpath = new GraphicsPath();
            graphicpath.StartFigure();
            graphicpath.AddArc(0, 0, 25, 25, 180, 90);
            graphicpath.AddLine(25, 0, this.Width - 25, 0);
            graphicpath.AddArc(this.Width - 25, 0, 25, 25, 270, 90);
            graphicpath.AddLine(this.Width, 25, this.Width, this.Height - 25);
            graphicpath.AddArc(this.Width - 25, this.Height - 25, 25, 25, 0, 90);
            graphicpath.AddLine(this.Width - 25, this.Height, 25, this.Height);
            graphicpath.AddArc(0, this.Height - 25, 25, 25, 90, 90);
            graphicpath.CloseFigure();
            this.Region = new Region(graphicpath);
}


        public Form1()
        {
           

            InitializeComponent();
            materialSkinManager= MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue600, MaterialSkin.Primary.Green300, MaterialSkin.Primary.Blue300, MaterialSkin.Accent.Yellow700,MaterialSkin.TextShade.WHITE);

            RePaint();

            
        }
        
        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "showPlots.py";
                process.StartInfo.WorkingDirectory = @".\backend";
                process.StartInfo.Arguments = "python";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input!");
            }
        }


        private void materialButton2_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
            }
            catch (Exception)
            {

                Console.WriteLine("DB can not open");
            }

            SQLiteCommand sQLiteCommand = conn.CreateCommand();
            sQLiteCommand.CommandText = "SELECT*FROM progress";


            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE progress SET projectsCompleted = " + materialTextBox1.Text + $" where weekday = '{DateTime.Now.DayOfWeek}'";
            command.Parameters.AddWithValue("projectsCompleted", materialTextBox1.Text);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();


            conn.Close();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
            {
                materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i)==true)
                {
                    checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                }
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            if (materialTextBox2.Text==string.Empty)
            {
                MessageBox.Show("Please, Enter a valid value!");
            }
            else
            {
                checkedListBox1.Items.Add(materialTextBox2.Text.Trim());
                materialTextBox2.Text = string.Empty;
            }

            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = $"INSERT INTO allProjects VALUES('{materialTextBox2.Text}', 1)";
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
 }

