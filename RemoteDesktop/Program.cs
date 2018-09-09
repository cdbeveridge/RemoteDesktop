using Microsoft.Win32;

namespace RemoteDesktop
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey fDeny = Registry.CurrentUser.OpenSubKey(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server", true);
            RegistryKey userAuth = Registry.CurrentUser.OpenSubKey(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", true);

            if (fDeny != null)
            {
                fDeny.SetValue("fDenyTSConnections", "0");
            }

            if (userAuth != null)
            {
                userAuth.SetValue("UserAuthentication", "1");
            }
            

        }
    }
}
