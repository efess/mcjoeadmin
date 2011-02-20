using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace McJoeAdmin
{
    public class StartupConfig
    {
        private const string MINECRAFT_EXECUTABLE_APP_KEY = "mc_exe";
        private const string MINECRAFT_STARTUP_FOLDER_APP_KEY = "mc_startup_folder";
        private const string MINECRAFT_ARGUMENTS_APP_KEY = "mc_arg{0}";

        public static string MinecraftExecutable
        {
            get
            {
                try
                {
                    var exe = ConfigurationManager.AppSettings[MINECRAFT_EXECUTABLE_APP_KEY]; 
                    if (!string.IsNullOrEmpty(exe))
                        return exe;
                }
                catch (ConfigurationErrorsException)
                {
                    // ignore.
                }
             
                return "DummyConsole.EXE";
            }
        }

        public static string MinecraftStartupFolder
        {
            get
            {
                try
                {
                    var strt = ConfigurationManager.AppSettings[MINECRAFT_STARTUP_FOLDER_APP_KEY];
                    if (!string.IsNullOrEmpty(strt))
                        return strt;
                }
                catch (ConfigurationErrorsException)
                {
                    // ignore.
                }

                return "";
            }
        }

        public static string[] MinecraftArguments
        {
            get
            {
                List<string> args = new List<string>();
                for (int i = 0; i < 30; i++)
                {
                    try
                    {
                        string arg 
                            = ConfigurationManager.AppSettings[string.Format(MINECRAFT_ARGUMENTS_APP_KEY, i)];

                        if (!string.IsNullOrEmpty(arg))
                            args.Add(arg);
                    }
                    catch (ConfigurationErrorsException)
                    {
                        // ignore.
                        continue;
                    }
                }

                return args.ToArray();
            }
        }
    }
}
