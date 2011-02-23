using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Minecraft;
using McJoeAdmin.Model;
using System.Reflection;
using System.IO;

namespace McJoeAdmin.Cortex
{
    /// <summary>
    /// Responsible for managing messages between the the Rules module, and the Minecraft Server
    /// </summary>
    public class MinecraftServerManager
    {
        private const int WAIT_PERIOD_SHUTDOWN = 5000;

        private IMcServer _serverInstance;
        private ModuleManager _moduleManager;

        public MinecraftServerManager(IMcServer pServer)
        {
            if (pServer == null)
                throw new ArgumentNullException("pMinecraft");

            _serverInstance = pServer;
            _moduleManager = ModuleManager.GetInstance(Path.GetDirectoryName(Assembly.GetCallingAssembly().Location),
                (mcm) => RouteMessage(mcm));
        }

        public Action<McMessage> ConsoleOut;

        private const string TEST_EXE =
            @"DummyConsole.exe";

        public MinecraftServerManager(string pExe, string[] pArgs, string pStartupFolder)
        {
            // TODO: Testing for now.
            _serverInstance = new McProcess(pExe, pArgs, pStartupFolder);
            _moduleManager = ModuleManager.GetInstance(Path.GetDirectoryName(Assembly.GetCallingAssembly().Location),
                (mcm) => RouteMessage(mcm));
            
        }

        public void StartServer()
        {
            if (_serverInstance == null
                || IsRunning)
                return;

            _serverInstance.ReadOutputLine += (sender, e) => RouteMessage(e.Message);
            _serverInstance.Start();
        }

        public bool IsRunning
        {
            get
            {
                return _serverInstance != null
                    && _serverInstance.IsRunning;
            }
        }

        private void RouteMessage(McMessage pMessage)
        {
            switch (pMessage.Origin)
            {
                case McMessageOrigin.ServerProcess:
                    _moduleManager.SendMessageToModuleHost(pMessage);
                    break;
                case McMessageOrigin.Module:
                case McMessageOrigin.View:
                    if (_serverInstance != null)
                        _serverInstance.WriteInputLine(pMessage.Data);
                    break;
            }
            if(ConsoleOut != null)
                ConsoleOut(pMessage);
        }

        public void SendConsoleInput(string pLine)
        {
            RouteMessage(new McMessage(pLine, McMessageOrigin.View, "View", DateTime.Now));
        }

        public void Shutdown()
        {
            if (_serverInstance == null
                || !IsRunning)
                return;

            // Allow modules to send last minute messages before forcing shutdown
            // IE. saving world
            _moduleManager.SendMessageToModuleHost(new McMessage(Constants.SPECIAL_MESSAGE_DATA_SHUTDOWN,
                McMessageOrigin.ServerManager,
                Constants.SPECIAL_MESSAGE_TYPE,
                DateTime.Now));


            System.Threading.Thread.Sleep(WAIT_PERIOD_SHUTDOWN);
                
            _serverInstance.Close();
        }

        public ServerInformation GetServerInformation()
        {
            return new ServerInformation(
                (_serverInstance.CurrentMemoryUsage / 1048576).ToString(),
                _serverInstance.CurrentCpuUsage.ToString(),
                _serverInstance.StartupString);
        }

    }
}
