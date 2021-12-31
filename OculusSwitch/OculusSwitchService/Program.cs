using System.ServiceProcess;

namespace OculusSwitchService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new OculusSwitchService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
