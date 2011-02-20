using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using McJoeAdmin.Model;

namespace McJoeAdmin
{
    public partial class Main : Form, IView
    {
        private bool _isFormClosing;
        private Timer _formUpdateTimer;

        private const int REFRESH_TIME_INTERVAL = 1000;

        public Main()
        {
            InitializeComponent();

            // Initialize implemented delegates
            InputText = null;
            StartServer = null;
            ShutdownServer = null;
            IsRunning = null;
            MemoryUsed = null;
            SetUpdateInterval = null;

            lblStartString.Text = string.Empty;
            lblMemoryUsage.Text = string.Empty;
            lblCpuUsage.Text = string.Empty;

            _formUpdateTimer = new Timer();
            _formUpdateTimer.Interval = REFRESH_TIME_INTERVAL;

            FormClosing += (sender, e) => HandleFormTryingToClose(e);

            btnSendInput.Click += (sender, e) => SendInput();

            _formUpdateTimer.Tick += (sender, e) => RefreshScreen();
        }

        private void WriteConsoleOutputLine(string pText)
        {
            if (_isFormClosing) return;

            if (txtConsoleOutput.InvokeRequired)
                try
                {
                    this.Invoke(new Action<string, TextBox>((str, txtbx) => SetTextToTextbox(str, txtbx)), pText, txtConsoleOutput);
                }
                catch { }
            else
                SetTextToTextbox(pText, txtConsoleOutput);
        }

        private void SetServerInformation(ServerInformation pServerInformation)
        {
            if (_isFormClosing) return;

            if (txtConsoleOutput.InvokeRequired)
                try
                {
                    this.Invoke(new Action<ServerInformation>((srvr) => SetServerInformationToPanel(srvr)), pServerInformation);
                }
                catch { }
            else
                SetServerInformationToPanel(pServerInformation);
        }

        private void SetServerInformationToPanel(ServerInformation pServerInformation)
        {
            lblCpuUsage.Text = pServerInformation.CpuUsage;
            lblMemoryUsage.Text = pServerInformation.MemoryUsage;
            lblStartString.Text = pServerInformation.StartupString;
        }

        private void SetTextToTextbox(string pText, TextBox textBox)
        {
            textBox.Text = pText;
            textBox.SelectionStart = textBox.TextLength;
            textBox.ScrollToCaret();
        }

        private void HandleFormTryingToClose(FormClosingEventArgs pFormClosingEventArgs)
        {
            if (_isFormClosing) return; // Impossable case?

            if(_isRunning())
                if (!PopupYesNoQuestionMessage("Sure you want to shutdown server?"))
                {
                    pFormClosingEventArgs.Cancel = true;
                    return;
                }

            _shutdownServer();

            _isFormClosing = true;
        }

        public void OutputConsoleText(string pText)
        {
            WriteConsoleOutputLine(pText);
        }

        public void ServerInformation(ServerInformation pServerInformation)
        {
            SetServerInformation(pServerInformation);
        }

        private bool PopupYesNoQuestionMessage(string pText)
        {
            return MessageBox.Show(this, pText, "lolQuestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes;
        }
        private void PopupInfoMessage(string pText)
        {
            MessageBox.Show(this, pText, "lolInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshScreen()
        {
        }

        //IStatusView Implementation
        private void SendInput()
        {
            if (!_isRunning())
            {
                PopupInfoMessage("Server is not running");
                return;
            }

            _inputText(txtConsoleInput.Text);
            txtConsoleInput.Text = string.Empty;
        }

        private Action<int> _setUpdateInterval;
        public Action<int> SetUpdateInterval
        {
            set
            {
                if (value == null)
                    _setUpdateInterval = (interval) => { };
                else
                    _setUpdateInterval = value;
            }
        }

        private Action<string> _inputText;
        public Action<string> InputText
        {
            set
            {
                if (value == null)
                    _inputText = (str) => { };
                else
                    _inputText = value;
            }
        }

        Action _startServer { get; set; }
        public Action StartServer
        {
            set
            {
                if (value == null)
                    _startServer = () => { };
                else
                    _startServer = value;
            }
        }

        Action _shutdownServer { get; set; }
        public Action ShutdownServer
        {
            set
            {
                if (value == null)
                    _shutdownServer = () => { };
                else
                    _shutdownServer = value;
            }
        }
        Func<bool> _isRunning { get; set; }
        public Func<bool> IsRunning
        {
            set
            {
                if (value == null)
                    _isRunning = () => { return false; };
                else
                    _isRunning = value;
            }
        }
        Func<long> _memoryUsed { get; set; }
        public Func<long> MemoryUsed
        {
            set
            {
                if (value != null)
                    _memoryUsed = () => { return 0L; };
                else
                    _memoryUsed = value;
            }
        }
    }
}
