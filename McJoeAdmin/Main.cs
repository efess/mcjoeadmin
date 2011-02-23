using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using McJoeAdmin.Model;
using System.Threading;
using System.Reflection;

namespace McJoeAdmin
{
    public partial class Main : Form, IView
    {
        private bool _isFormClosing;
        private Queue<object> _updateQueue;
        private Action _updateQueueConsumerDelegate;
        private bool _scrollAtBottom = true;
        public Main()
        {

            InitializeComponent();
            _updateQueueConsumerDelegate = new Action(ProcessUpdateQueue);
            _updateQueue = new Queue<object>();

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

            FormClosing += (sender, e) => HandleFormTryingToClose(e);

            btnSendInput.Click += (sender, e) => SendInput();


            Type t = gridConsoleOut.GetType();
            PropertyInfo pi = t.GetProperty("VerticalScrollBar", BindingFlags.Instance | BindingFlags.NonPublic);
            ScrollBar s = null;

            if (pi != null)
                s = pi.GetValue(gridConsoleOut, null) as ScrollBar;

            if (s != null)
            {
                s.Scroll += (sender, e) => HandleScroll(new GridVerticalScrollEventArgs(e, s.Maximum));
            }

            //_formUpdateTimer.Tick += (sender, e) => RefreshScreen();
            //_formUpdateTimer.Enabled = true;
        }

        private void HandleScroll(GridVerticalScrollEventArgs e)
        {
            if(e.InnerEventArgs.Type == ScrollEventType.EndScroll)
            {

                if ((e.MaximumValue - gridConsoleOut.Height) < e.InnerEventArgs.NewValue)
                    _scrollAtBottom = true;
                else
                    _scrollAtBottom = false;
            }
        }

        private void SetServerInformationToPanel(ServerInformation pServerInformation)
        {
            lblCpuUsage.Text = pServerInformation.CpuUsage + "%";
            lblMemoryUsage.Text = pServerInformation.MemoryUsage + "MB";
            lblStartString.Text = pServerInformation.StartupString;
        }

        private void SetTextToTextbox(McMessage pMessage)
        {
            if (gridConsoleOut.Rows.Count > 500)
            {
                gridConsoleOut.Rows.RemoveAt(0);
            }
            gridConsoleOut.Rows.Add(pMessage.Date.ToString("MM/dd/yyyy HH:mm:ss"),
                pMessage.Origin.ToString(),
                pMessage.Type,
                pMessage.Data);

            if(_scrollAtBottom)
                gridConsoleOut.FirstDisplayedScrollingRowIndex = gridConsoleOut.Rows.Count - 1;
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

        public void OutputConsoleText(McMessage pMessage)
        {
            lock (_updateQueue)
                _updateQueue.Enqueue(pMessage);
            
            //if(InvokeRequired)
            //    this.Invoke(_updateQueueConsumerDelegate);
            //else
            //    ProcessUpdateQueue();
        }

        public void ServerInformation(ServerInformation pServerInformation)
        {
            lock (_updateQueue)
                _updateQueue.Enqueue(pServerInformation);
            
            //if(InvokeRequired)
            //    this.Invoke(_updateQueueConsumerDelegate);
            //else
            //    ProcessUpdateQueue();
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
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            ProcessUpdateQueue();
        }
        private void ProcessUpdateQueue()
        {
            if (InvokeRequired) return;

            lock (_updateQueue)
            {
                int updates = 0;
                while (_updateQueue.Count > 0)
                {
                    var update = _updateQueue.Dequeue();

                    try // Do NOT throw an exception
                    {
                        updates++;

                        if (updates > 100)
                            return;
                        lblStatus.Text = "Processing updates..";

                        if (update is ServerInformation)
                            SetServerInformationToPanel(update as ServerInformation);
                        else if (update is McMessage)
                            SetTextToTextbox(update as McMessage);
                    }
                    catch (Exception ex) { }
                    finally
                    {
                        lblStatus.Text = string.Empty;
                    }
                }
            }
        }

        //IStatusView Implementation
        private void SendInput()
        {
            if (!_isRunning())
            {
                PopupInfoMessage("Server is not running");
                return;
            }
            if(!string.IsNullOrEmpty(txtConsoleInput.Text))
            {
                _inputText(txtConsoleInput.Text);
                txtConsoleInput.Text = string.Empty;
            }
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

    public class GridVerticalScrollEventArgs
    {
        public ScrollEventArgs InnerEventArgs { get; private set; }
        public int MaximumValue { get; private set; }

        public GridVerticalScrollEventArgs(ScrollEventArgs pEventArgs, int pMaximumValue)
        {
            InnerEventArgs = pEventArgs;
            MaximumValue = pMaximumValue;
        }
    }
}
