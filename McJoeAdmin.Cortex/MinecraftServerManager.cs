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
            
        public Action<string> ConsoleOut;

        private const string TEST_EXE = 
            @"..\..\..\DummyConsole\bin\Debug\DummyConsole.exe";

        public MinecraftServerManager(string pExe, string[] pArgs)
        {
            // TODO: Testing for now.
            _serverInstance = new McProcess(TEST_EXE, new string[0]);
            StartServer();
        }

        public void StartServer()
        {
            if (_serverInstance == null
                || IsRunning)
                return;

            _serverInstance.ReadOutputLine += (sender, e) => RaiseConsoleOut(e.Data);
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

        private void RaiseConsoleOut(string pLine)
        {
            if (ConsoleOut != null)
                ConsoleOut(pLine);
        }

        public void SendConsoleInput(string pLine)
        {
            if (_serverInstance == null)
                return;

            _serverInstance.WriteInputLine(pLine);
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
