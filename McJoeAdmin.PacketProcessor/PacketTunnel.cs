using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;

namespace McJoeAdmin.PacketProcessor
{
    public class PacketTunnel
    {
        private int _mcPort;
        private string _mcHost;

        private int _listenPort;
        
        private Socket _listenSocket;

        private bool _shutDownThreads;

        public PacketTunnel(int pMcPort, int pListenPort)
            : this(pMcPort, pListenPort, "localhost")
        {
        }

        public PacketTunnel(int pMcPort, int pListenPort, string pMcEndPoint)
        {
            _mcPort = pMcPort;
            _mcHost = pMcEndPoint;
            _listenPort = pListenPort;
            _listenSocket = new Socket(new SocketInformation());
            
            StartListen();
        }


        private void StartListen()
        {
            new Action(() => WaitAndAcceptConnection()).BeginInvoke(ParameterlessActionEndInvoke, null);
            _listenSocket.Bind(new IPEndPoint(IPAddress.Any, _listenPort));
            _listenSocket.Listen(10);
        }

        private void WaitAndAcceptConnection()
        {
            while (!_shutDownThreads)
            {
                var socket = _listenSocket.Accept();

                new Action<Socket>(
                    (sock) => ManageSocketConnection(sock))
                    .BeginInvoke(socket, SocketActionEndInvoke, null);
            }
        }

        // This will start to be huge while I figure out exactly how this will work.
        // WIll eventually be in its own class
        // Design after code.. woo!
        private void ManageSocketConnection(Socket pUserSocket)
        {
            var hostEntry = Dns.GetHostEntry(_mcHost);

            Socket mcSocket = new Socket(new SocketInformation());

            mcSocket.Connect(hostEntry.AddressList, _mcPort);

            byte[] buffer = new byte[1024];
            
            while(!_shutDownThreads)
            {
                int received = pUserSocket.Receive(buffer, 1024, SocketFlags.None);
                mcSocket.Send(buffer, received, SocketFlags.None);
            }
        }

        private void ParameterlessActionEndInvoke(IAsyncResult result)
        {
            var asyncResult = (result as AsyncResult);
            var actionDelegate = asyncResult.AsyncDelegate as Action;

            if (actionDelegate != null)
                actionDelegate.EndInvoke(result);
        }

        private void SocketActionEndInvoke(IAsyncResult result)
        {
            var asyncResult = (result as AsyncResult);
            var actionDelegate = asyncResult.AsyncDelegate as Action<Socket>;

            if (actionDelegate != null)
                actionDelegate.EndInvoke(result);
        }
    }
}
