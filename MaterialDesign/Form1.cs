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

namespace MaterialDesign
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue600, MaterialSkin.Primary.Green300, MaterialSkin.Primary.Blue300, MaterialSkin.Accent.Yellow700,MaterialSkin.TextShade.WHITE);


        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
