using System.ServiceProcess;

namespace OculusSwitchService
{
    public partial class OculusSwitchService : ServiceBase
    {
        uint _cookie = 0;

        public OculusSwitchService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Register the SimpleObject class object on start
            int hResult = COMNative.CoRegisterClassObject(
                OculusControlComService.ClassId,              // CLSID to be registered
                new OculusControlComServiceClassFactory(),    // Class factory
                (uint)COMNative.CLSCTX.CLSCTX_LOCAL_SERVER,   // Context to run
                (uint)COMNative.REGCLS.MULTIPLEUSE,
                out _cookie);
        }

        protected override void OnStop()
        {
            COMNative.CoRevokeClassObject(_cookie);
        }
    }
}
