using System.ServiceProcess;

namespace OculusSwitchService
{
    public partial class OculusSwitchService : ServiceBase
    {
        public OculusSwitchService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
