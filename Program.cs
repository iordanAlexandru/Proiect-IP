using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Ip
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            Stereo stereo = new Stereo();

            // we can change command dynamically 
            remote.Command = new LightOnCommand(light);
            remote.buttonWasPressed();
            remote.Command = new StereoOnWithCDCommand(stereo);
            remote.buttonWasPressed();
            remote.Command = new StereoOffCommand(stereo);
            remote.buttonWasPressed();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
