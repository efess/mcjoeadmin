using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using McJoeAdmin.Model;
using McJoeAdmin.Model.Events;

namespace McJoeAdmin.Minecraft
{
    /// <summary>
    /// Manages a MInecraft server by directly wrapping the executable
    /// </summary>
    public class McProcess : IMcServer, IDisposable
    {
        public event McMessageEventHandler ReadOutputLine;

        private const int KILL_WAIT_TIMEOUT_MS = 5000;

        private string _exePath;
        private string[] _arguments;
        private Process _process;

        private string _startupArguments;
        private string _startupFolder;

        private double _lastCpuMilliseconds;

        private bool disposedProperly;

        public McProcess(string pExePath, string[] pArguments, string pStartupFolder)
        {
            _exePath = pExePath;
            _arguments = pArguments;
            _startupFolder = pStartupFolder;
            _startupArguments = FormatArguments();
        }

        public void Start()
        {
            if(IsRunning)
                return;
            
            _process = new Process();
            _process.StartInfo = new ProcessStartInfo(_exePath, _startupArguments)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    CreateNoWindow = true,
                    ErrorDialog = false,
                    WorkingDirectory = _startupFolder,
                    UseShellExecute = false
                };
            _process.OutputDataReceived += (sender, e) =>  ProcessOutputLine(e.Data, false);
            _process.ErrorDataReceived += (sender, e) => ProcessOutputLine(e.Data, true);
            _process.Exited += (sender, e) => Close();

            _process.Start();

            _process.BeginErrorReadLine();
            _process.BeginOutputReadLine();
        }

        public void Close()
        {
            if (!IsRunning)
                return;

            _process.Kill();
            _process.WaitForExit(KILL_WAIT_TIMEOUT_MS);
            
            _process.Close();
            _process = null;
        }

        public string StartupString { get { return _exePath + " " + _startupArguments; } }

        public long CurrentMemoryUsage
        {
            get
            {
                if (!IsRunning)
                    return 0L;
                return _process.PrivateMemorySize64;
            }
        }

        public float CurrentCpuUsage
        {
            get
            {
                if (!IsRunning)
                    return 0f;
                
                // TODO: I have more important things right now...
                return 0.0f;
            }
        }

        public bool IsRunning
        {
            get
            {
                return _process != null
                    && !_process.HasExited;
            }
        }

        private string FormatArguments()
        {
            var sb = new StringBuilder();
            foreach (string str in _arguments)
            {
                sb.Append(str);
                sb.Append(" ");
            }

            return sb.ToString();
        }

        private void ProcessOutputLine(string pData, bool pIsError)
        {
            if (!IsRunning)
                return;
            if (ReadOutputLine != null)
                ReadOutputLine(this, 
                    new McMessageEventArgs(
                        McLogParser.Parse(pData)));
        }

        public void WriteInputLine(string pData)
        {
            if (!IsRunning)
                return;
            Console.WriteLine(pData);

            _process.StandardInput.WriteLine(pData);
        }

        ~McProcess()
        {
            Dispose(false);
        }

        public void Dispose(bool pDisposeProperly)
        {
            if(pDisposeProperly)
                Close();
        }

        public void Dispose()
        {
            System.IO.File.Create("D:\\BIN\\DISPOSED.TXT");
            Dispose(true);
        }
    }
}
