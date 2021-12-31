
using System.ServiceProcess;

namespace OculusSwitchService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oculusSwitchServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.oculusSwitchServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller
            // 
            this.oculusSwitchServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.oculusSwitchServiceProcessInstaller.Password = null;
            this.oculusSwitchServiceProcessInstaller.Username = null;
            // 
            // OculusSwitchService
            // 
            this.oculusSwitchServiceInstaller.Description = "Service used by the Oculus Switch Tray App";
            this.oculusSwitchServiceInstaller.DisplayName = "Service used by the Oculus Switch Tray App";
            this.oculusSwitchServiceInstaller.ServiceName = "Oculus Switch Service";
            this.oculusSwitchServiceInstaller.StartType = ServiceStartMode.Automatic;

            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.oculusSwitchServiceProcessInstaller,
            this.oculusSwitchServiceInstaller});
        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller oculusSwitchServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller oculusSwitchServiceInstaller;
    }
}