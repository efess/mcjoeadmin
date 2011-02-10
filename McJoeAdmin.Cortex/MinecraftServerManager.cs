using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Minecraft;
using McJoeAdmin.Model;

namespace McJoeAdmin.Cortex
{
    /// <summary>
    /// Responsible for managing messages between the the Rules module, and the Minecraft Server
    /// </summary>
    public class MinecraftServerManager
    {
        private IMcServer _serverInstance;

        public MinecraftServerManager(IMcServer pServer)
        {
            if (pServer == null)
                throw new ArgumentNullException("pMinecraft");

            _serverInstance = pServer;
        }

        public Action<McMessage> ConsoleOut;

        private const string TEST_EXE =
            @"..\..\..\DummyConsole\bin\Debug\DummyConsole.exe";

        public MinecraftServerManager(string pExe, string[] pArgs)
        {
            // TODO: Testing for now.
            _serverInstance = new McProcess(TEST_EXE, new string[0]);
        }

        public void StartServer()
        {
            if (_serverInstance == null
                || IsRunning)
                return;

            _serverInstance.ReadOutputLine += (sender, e) => RouteMessage(new McMessage(e.Data, McMessageOrigin.ServerEngine));
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
                    ConsoleOut(pMessage);
                    break;
                case McMessageOrigin.AdminRule:
                case McMessageOrigin.AdminView:
                    if (_serverInstance == null)
                        return;

                    _serverInstance.WriteInputLine(pMessage.Data);
                    break;
            }
        }

        private void FromServerEngine(string pLine)
        {
            var mcMessage = new McMessage(pLine, McMessageOrigin.ServerEngine);

            RaiseConsoleOut(mcMessage);
        }

        private void FromAdminView(string pLine)
        {
            var mcMessage = new McMessage(pLine, McMessageOrigin.AdminView);

            if (_serverInstance == null)
                return;

            _serverInstance.WriteInputLine(pLine);
        }

        private void FromAdminRules(string pLine)
        {

        }

        private void RaiseConsoleOut(McMessage pMessage)
        {
            if (ConsoleOut != null)
                ConsoleOut(pMessage);
        }

        public void SendConsoleInput(string pLine)
        {
            RouteMessage(new McMessage(pLine, McMessageOrigin.AdminView));
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
