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
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "showPlots.py";
                process.StartInfo.WorkingDirectory = @"C:\Users\chess\source\repos\MaterialDesign\MaterialDesign\bin\Debug\backend";
                process.StartInfo.Arguments = "python";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid input!");
            }
        }
    }
}
