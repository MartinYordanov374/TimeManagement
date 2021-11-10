using System;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace backend
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isOsLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            string command = "python3 showPlots.py";

            if( isOsLinux == true) 
            {
                string linuxExecutionString = "-c \" " + command + " \"";
                Process proc = new Process ();
                proc.StartInfo.FileName = "/bin/bash";
                proc.StartInfo.Arguments = linuxExecutionString;
                proc.StartInfo.UseShellExecute = false; 
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start ();
            }
            else
            {
               Process.Start("CMD.exe",command);
            }
            
        }
    }
}
