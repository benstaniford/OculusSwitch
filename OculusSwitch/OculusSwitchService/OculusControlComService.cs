using System;
using System.Runtime.InteropServices;

namespace OculusSwitchService
{
    [Guid("83C40736-3189-44bc-AB0F-9FB3703EA172"), ComVisible(true)]  //IID_IOculusControlComService
    public interface IOculusControlComService
    {
        int TestingThings();
    }

    [ClassInterface(ClassInterfaceType.None)]
    [Guid("F47CC890-2151-4DC9-AD0B-AB970EB14466"), ComVisible(true)]
    public class OculusControlComService : IOculusControlComService
    {
        public static Guid ClassId = new Guid("F47CC890-2151-4DC9-AD0B-AB970EB14466");

        public OculusControlComService()
        {
            // Initialize COM security  (https://www.pinvoke.net/default.aspx/ole32.coinitializesecurity suggests this won't work due to CoInitialize being called to early)
            /*
            int hResult = COMNative.CoInitializeSecurity(
                IntPtr.Zero,    // Add your security descriptor here
                -1, IntPtr.Zero, IntPtr.Zero, RPC_C_AUTHN_LEVEL.PKT_PRIVACY,
                RPC_C_IMP_LEVEL.IDENTIFY, IntPtr.Zero,
                EOLE_AUTHENTICATION_CAPABILITIES.DISABLE_AAA |
                EOLE_AUTHENTICATION_CAPABILITIES.SECURE_REFS |
                EOLE_AUTHENTICATION_CAPABILITIES.NO_CUSTOM_MARSHAL,
               IntPtr.Zero);
            */
        }

        public int TestingThings()
        {
            return 23;
        }
    }
}
