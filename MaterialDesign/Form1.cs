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
using System.Drawing.Text;

namespace MaterialDesign
{

    public partial class Form1 : MaterialForm
    {

        SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\backend\progressDatabase.db");
        int count;
        int temp = 0;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public Form1()
        {
            InitializeComponent();
            
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange800, MaterialSkin.Accent.Orange400, MaterialSkin.TextShade.WHITE);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;

            if (true)
            {
                errorProvider1.SetError(chart1, "You should turn on  again the app to see new values of chart");
            }
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

            conn.Open();
            SQLiteCommand sQLiteCommand = conn.CreateCommand();
            sQLiteCommand.CommandText = $"SELECT projectsCompleted FROM progress where weekday = '{DateTime.Now.DayOfWeek}'";
            sQLiteCommand.ExecuteNonQuery();
            var rd = sQLiteCommand.ExecuteReader();

            int temp = 0;
            while (rd.Read())
            {
                temp = int.Parse(rd["projectsCompleted"].ToString());
            }
            materialLabel1.Text = temp.ToString();
            rd.Close();
            conn.Close();

            conn.Open();
            int result = 0;
            SQLiteCommand CMD = conn.CreateCommand();
            CMD.CommandText = $"SELECT projectsDue FROM projectsDue";
            CMD.ExecuteNonQuery();
            var rds = CMD.ExecuteReader();

            while (rds.Read())
            {
                result = int.Parse(rds["projectsDue"].ToString());
            }
            rds.Close();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO projectsDue  (projectsDue ) VALUES(@result)";
            cmd.Parameters.AddWithValue("@result", result);
            cmd.ExecuteNonQuery();

            materialLabel3.Text = result.ToString();
            conn.Close();
            Fill();

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SQLiteCommand sQLiteCommand = conn.CreateCommand();

                var index = checkedListBox1.SelectedIndex;

                var name = checkedListBox1.Items[index].ToString();

                var query = $"DELETE FROM allProjects WHERE projectName == '{name}'";

                sQLiteCommand.CommandText = query;

                sQLiteCommand.ExecuteNonQuery();

                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);

                sQLiteCommand.CommandText = $"SELECT projectsCompleted FROM progress where weekday = '{DateTime.Now.DayOfWeek}'";

                var rd = sQLiteCommand.ExecuteReader();

                while (rd.Read())
                {
                    count = int.Parse(rd["projectsCompleted"].ToString()) + 1;

                    SQLiteCommand comm = conn.CreateCommand();

                    comm.CommandText = "UPDATE progress SET projectsCompleted = " + count + $" where weekday = '{DateTime.Now.DayOfWeek}'";

                    comm.ExecuteNonQuery();
                }
                rd.Close();
                conn.Close();


                conn.Open();
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = $"SELECT projectsCompleted FROM progress where weekday = '{DateTime.Now.DayOfWeek}'";
                command.ExecuteNonQuery();
                var readers = command.ExecuteReader();

                while (readers.Read())
                {
                    temp = int.Parse(readers["projectsCompleted"].ToString());
                    temp = count;
                }

                materialLabel1.Text = temp.ToString();
                readers.Close();
                conn.Close();


                conn.Open();
                SQLiteCommand CMD = conn.CreateCommand();
                CMD.CommandText = $"SELECT projectsDue FROM projectsDue";
                CMD.ExecuteNonQuery();
               
                conn.Close();
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }
        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            SQLiteCommand sQLiteCommand = conn.CreateCommand();

            sQLiteCommand.CommandText = "SELECT*FROM allProjects";

            checkedListBox1.Items.Clear();

            var reader = sQLiteCommand.ExecuteReader();

            while (reader.Read())
            {
                checkedListBox1.Items.Add(reader.GetString(0));
            }

            reader.Close();

            conn.Close();

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();

                if (materialTextBox2.Text != string.Empty)
                {
                    checkedListBox1.Items.Add(materialTextBox2.Text);

                    cmd.CommandText = "INSERT INTO allProjects (projectName) VALUES(@materialTextBox2)";

                    string name = materialTextBox2.Text;

                    cmd.Parameters.AddWithValue("@materialTextBox2", name);

                    cmd.ExecuteNonQuery();
                }
                materialTextBox2.Clear();
                
                conn.Close();

                conn.Open(); 
                SQLiteCommand query = conn.CreateCommand();
                int result = 0;
                query.CommandText = $"SELECT projectsDue FROM projectsDue";
                query.ExecuteNonQuery();
                var rds = query.ExecuteReader();

                while (rds.Read())
                {
                    result = int.Parse(rds["projectsDue"].ToString());
                }
                rds.Close();
                SQLiteCommand CMD = conn.CreateCommand();

                result += 1;
                CMD.CommandText = "UPDATE projectsDue  SET projectsDue  = " + result;
                
                CMD.ExecuteNonQuery();
                materialLabel3.Text = result.ToString();
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }


        private void materialTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                materialButton1.PerformClick();
            }
        }

        public void Fill()
        {
            //AddXY value in chart1 in series named as Salary  
            chart1.Series["Task"].Points.AddXY("AddDayProjects", materialLabel1.Text);
            chart1.Series["Task"].Points.AddXY("TotalProjects", materialLabel3.Text);
            //chart title  
            
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            chart1.Hide();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            chart1.Show();
        }


        private void materialButton5_Click_1(object sender, EventArgs e)
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

            conn.Close();

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void materialLabel7_Click(object sender, EventArgs e)
        {
            materialLabel7.Text = "Programming is my favorite hobby and hopefully a future profession. " +
                "I like .NET, JS and backend programming.";
            
        }
    }
}