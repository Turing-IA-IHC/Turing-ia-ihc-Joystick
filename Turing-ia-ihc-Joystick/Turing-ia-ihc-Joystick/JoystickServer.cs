using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Turing_ia_ihc_Joystick
{
    public class JoystickServer
    {
        #region Event Objects
        /// <summary>
        /// Estructura del evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void DataEventArgsEventHandler(object sender, Data e);

        /// <summary>
        /// Variable of event
        /// </summary>
        public event DataEventArgsEventHandler DataReceived;

        /// <summary>
        /// Event
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDataReceived(Data e)
        {
            DataEventArgsEventHandler handler = DataReceived;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        #endregion Event Objects

        #region Network objects
        private TcpClient ServerSocket;
        private TcpListener LocalPort;

        /// <summary>
        /// Port to listen
        /// </summary>
        public int Port { get { return _Port; } }
        private int _Port = 53211;

        /// <summary>
        /// Say if port is open
        /// </summary>
        public bool isOpen { get { return _isOpen; } }
        private bool _isOpen = false;

        /// <summary>
        /// Start configuration to open port
        /// </summary>
        /// <param name="port"></param>
        public void Config(int Port)
        {
            this._Port = Port;
        }
        #endregion Network objects

        /// <summary>
        /// Message to show on start connection
        /// </summary>
        public string InitialMessage { get; set; }

        /// <summary>
        /// If true, re sent to client the same message received
        /// </summary>
        public bool AutoReplyClientMessage { get; set; }

        /// <summary>
        /// Start server socket
        /// </summary>
        public void Start()
        {
            LocalPort = new TcpListener(System.Net.IPAddress.Any, this.Port);
            LocalPort.Start();

            ServerSocket = default(TcpClient);
            ServerSocket = LocalPort.AcceptTcpClient();

            this._isOpen = true;

            if (this.InitialMessage != "")
            {
                this.Send(this.InitialMessage);
            }

            Received();
        }
    
        /// <summary>
        /// Close port
        /// </summary>
        public void Stop()
        {
            if (ServerSocket != null)
            {
                if (ServerSocket.Client != null && ServerSocket.Client.Connected)
                    ServerSocket.Client.Close();
                ServerSocket.Close();
            }
            if (LocalPort != null)
                LocalPort.Stop();

            this._isOpen = false;
        }

        /// <summary>
        /// If server is stop then start it, else stop.
        /// </summary>
        public void Toggle()
        {
            if (this.isOpen)
                Stop();
            else
                Start();
        }

        /// <summary>
        /// Funciton to receive message from client
        /// </summary>
        public async void Received()
        {
            NetworkStream networkStream = ServerSocket.GetStream();
            while (this.isOpen)
            {
               try
               {
                    byte[] bytesFrom = new byte[65536];
                    await networkStream.ReadAsync(bytesFrom, 0, (int)ServerSocket.ReceiveBufferSize);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("\0"));

                    if (dataFromClient.Trim() != "")
                    {
                        Data d = new Data(((System.Net.IPEndPoint)ServerSocket.Client.RemoteEndPoint).Address.ToString(), 
                            dataFromClient, DateTime.Now);
                        OnDataReceived(d);

                        if (this.AutoReplyClientMessage)
                        {
                            this.Send(dataFromClient);
                        }
                    }

                    networkStream.Flush();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                await Task.Delay(1);
            }
        }

        /// <summary>
        /// Send message to client
        /// </summary>
        /// <param name="smg">Message to send</param>
        public async void Send(string smg)
        {
            NetworkStream networkStream = ServerSocket.GetStream();
            Byte[] sendBytes = Encoding.ASCII.GetBytes(smg);
            networkStream.Write(sendBytes, 0, sendBytes.Length);
            await Task.Delay(1);
        }
    }
}
