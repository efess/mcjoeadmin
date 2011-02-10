using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;
using McJoeAdmin.Cortex;

namespace McJoeAdmin.ViewManager
{
    /// <summary>
    /// Manages the View and interactions with the Cortex
    /// </summary>
    public class ViewManager
    {
        private StringBuilder _outputLog;
        private int _currentLines = 0;
        private int _logMaxLines = 500;

        private IView _view;
        private MinecraftServerManager _serverManager;

        public ViewManager(IView pView, MinecraftServerManager pServerManager)
        {
            _serverManager = pServerManager;
            _view = pView;
            _outputLog = new StringBuilder();

            HookupEvents();
        }

        private void HookupEvents()
        {
            _view.InputText = _serverManager.SendConsoleInput;
            _view.IsRunning = () => _serverManager.IsRunning;
            _view.ShutdownServer = _serverManager.Shutdown;
            _view.StartServer = _serverManager.StartServer;
            _serverManager.ConsoleOut = WriteToConsoleOutput;
        }

        private void WriteToConsoleOutput(string pNewLine)
        {

            if (_currentLines > _logMaxLines)
            {
                string currentLog = _outputLog.ToString();
                _outputLog.Remove(0, currentLog.IndexOf(Environment.NewLine) + Environment.NewLine.Length);
                _currentLines = _logMaxLines;
            }
            else 
            {
                _currentLines++;
            }

            _outputLog.AppendLine(pNewLine);

            _view.OutputConsoleText(_outputLog.ToString());
        }        
    }
}
