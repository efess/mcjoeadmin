using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using McJoeAdmin.Cortex;

namespace McJoeAdmin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var mainForm = new Main();

            var serverManager = new MinecraftServerManager(StartupConfig.MinecraftExecutable, StartupConfig.MinecraftArguments, StartupConfig.MinecraftStartupFolder);
            var viewManager = new ViewManager.ViewManager(mainForm, serverManager);
            serverManager.StartServer();

            Application.Run(mainForm);
        }
    }
}
