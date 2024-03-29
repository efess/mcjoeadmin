﻿using System;
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
        private const int UPDATE_TIMER_DEFAULT = 1000;

        private System.Timers.Timer _timer;

        private IView _view;
        private MinecraftServerManager _serverManager;

        public ViewManager(IView pView, MinecraftServerManager pServerManager)
        {
            _serverManager = pServerManager;
            _view = pView;
            _timer = new System.Timers.Timer(UPDATE_TIMER_DEFAULT);
            _timer.Elapsed += (sender, e) => UpdateView();
            _timer.Enabled = true;

            HookupEvents();
        }

        private void SetUpdateTimer(int pTimerInterval)
        {
            _timer.Interval = pTimerInterval;
        }

        private void UpdateView()
        {
            _view.ServerInformation(_serverManager.GetServerInformation());
        }

        private void HookupEvents()
        {
            _view.InputText = _serverManager.SendConsoleInput;
            _view.IsRunning = () => _serverManager.IsRunning;
            _view.ShutdownServer = _serverManager.Shutdown;
            _view.StartServer = _serverManager.StartServer;
            _view.SetUpdateInterval = SetUpdateTimer;
            _serverManager.ConsoleOut = WriteToConsoleOutput;
        }

        private void WriteToConsoleOutput(McMessage pMessage)
        {
            _view.OutputConsoleText(pMessage);
        }        
    }
}
