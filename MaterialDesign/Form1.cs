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
      
        public Form1()
        {
           

            InitializeComponent();

            materialSkinManager= MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green800, MaterialSkin.Primary.Green800, MaterialSkin.Accent.Teal700,MaterialSkin.TextShade.WHITE);

          
            try
            {
                Process process = new Process();

                process.StartInfo.FileName = "databaseScript.py";
                process.StartInfo.WorkingDirectory = @".\backend";
                process.StartInfo.Arguments = "python";

                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                process.Start();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }

            materialLabel2.Text = DateTime.Now.ToLongDateString();
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
            try
            {
                conn.Open();

                SQLiteCommand sQLiteCommand = conn.CreateCommand();
                
                var index = checkedListBox1.SelectedIndex;
                var name = checkedListBox1.Items[index].ToString();
                var query= $"DELETE FROM allProjects WHERE projectName == '{name}'";

                sQLiteCommand.CommandText = query;
                sQLiteCommand.ExecuteNonQuery();

                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);

                conn.Close();

            }
            catch (Exception es)
            {
                MessageBox.Show("ERROR "+es.Message);
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                var cmd = new SQLiteCommand(conn);

                if (materialTextBox2.Text != string.Empty)
                {
                    checkedListBox1.Items.Add(materialTextBox2.Text);

                    cmd.CommandText = "INSERT INTO allProjects (projectName) VALUES(@materialTextBox2)";

                    string name = materialTextBox2.Text;

                    cmd.Parameters.AddWithValue("@materialTextBox2", name);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            catch (Exception es)
            {
                MessageBox.Show("ERROR " + es.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
           
            var cmd = new SQLiteCommand(conn);

            cmd.CommandText = "SELECT * FROM allProjects";

            checkedListBox1.Items.Clear();

           var reader= cmd.ExecuteReader();
          
            while (reader.Read())
            {
                checkedListBox1.Items.Add(reader.GetString(0));
            }

            reader.Close();

            conn.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

      
    }
 }

