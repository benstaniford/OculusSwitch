using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OculusSwitchTray
{
    public partial class OculusSwitchTrayForm : Form
    {
        public OculusSwitchTrayForm()
        {
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            Hide();
        }

        public static dynamic ComObjectGet()
        {
            const string progID = "OculusSwitchService.OculusControlComService";
            Type comType = Type.GetTypeFromProgID(progID);
            if (comType == null)
            {
                throw new Exception("Oculus Switch COM service does not appear to be started");
            }

            //var bar = Guid.Parse ("99929AA7-0334-4B2D-AC74-5E282A12D06C");
            //Type foo = Type.GetTypeFromCLSID (bar);

            dynamic comObject = Activator.CreateInstance(comType);
            return comObject;
        }

        //This Starts the Oculus
        private void turnOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var comServer = ComObjectGet();
                int result = comServer.TestingThings();
                MessageBox.Show($"Result from COM was {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "COM Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProcessStartInfo info = new ProcessStartInfo(@"C:\StartOculus.bat");
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            Process processChild = Process.Start(info);
            {
                this.notifyIcon.BalloonTipText = "Oculus has been turned On";
                this.notifyIcon.BalloonTipTitle = "Oculus Switch";
                this.notifyIcon.Icon = OculusSwitchTray.Properties.Resources.Oculus;
                this.notifyIcon.Visible = true;
                this.notifyIcon.ShowBalloonTip(5);
                this.notifyIcon.Icon = OculusSwitchTray.Properties.Resources.Green;
            }

        }

        //This Stops the Oculus
        private void turnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Oculus has been turned Off");
            ProcessStartInfo info = new ProcessStartInfo(@"C:\StopOculus.bat");
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            Process processChild = Process.Start(info);
            {
                    this.notifyIcon.BalloonTipText = "Oculus has been turned Off";
                    this.notifyIcon.BalloonTipTitle = "Oculus Switch";
                    this.notifyIcon.Icon = OculusSwitchTray.Properties.Resources.Oculus;
                    this.notifyIcon.Visible = true;
                    this.notifyIcon.ShowBalloonTip(5);
                    this.notifyIcon.Icon = OculusSwitchTray.Properties.Resources.Red;
                }
        }

        //This opens a dialog box of how to use the App
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                " -This app must run at 'Admin' privileges to work.\n - Close any instances of this app, right click the app and choose\n 'Run This Program As An Administrator'.",

                "Created by @awalkingspastic");
        }

        //This Exits the App
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

            /*
            DialogResult messageBoxResult = MessageBox.Show
            ("Oculus has been turned On", "Oculus Switch", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (messageBoxResult == DialogResult.OK);

            //MessageBox.Show("Oculus has been turned On");
            */
        }
    }
}
