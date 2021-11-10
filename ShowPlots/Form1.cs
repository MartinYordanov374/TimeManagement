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

namespace ShowPlots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                Process process = new Process();
                process.StartInfo.FileName = "showPlots.py";
         
                process.StartInfo.Arguments = "python";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
             
            }
            catch (Exception ex)
            {

                Console.WriteLine("errpr");
            }
        }
    }
}
