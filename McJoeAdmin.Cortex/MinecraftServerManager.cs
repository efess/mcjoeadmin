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

        public MinecraftServerManager(string pExe, string[] pArgs)
        {
            // TODO: Testing for now.
            _serverInstance = new McProcess(TEST_EXE, new string[0]);
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
                case McMessageOrigin.ServerEngine:
                    _moduleManager.SendMessageToModuleHost(pMessage);
                    break;
                case McMessageOrigin.AdminRule:
                case McMessageOrigin.AdminView:
                    if (_serverInstance != null)
                        _serverInstance.WriteInputLine(pMessage.Data);
                    break;
            }
            ConsoleOut(pMessage);
        }

        public void SendConsoleInput(string pLine)
        {
            RouteMessage(new McMessage(pLine, McMessageOrigin.AdminView, "View", DateTime.Now));
        }

        public void Shutdown()
        {
            if (_serverInstance == null
                || !IsRunning)
                return;

            _serverInstance.Close();
        }
    }
}
