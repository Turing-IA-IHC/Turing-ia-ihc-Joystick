using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Turing_ia_ihc_Joystick
{
    public class JoystickClient
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
        private TcpClient ClientSocket = new TcpClient();

        /// <summary>
        /// IP Address of the server
        /// </summary>
        public string IPAddress { get { return _IPAddress; } }
        private string _IPAddress = "localhost";

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
        public void Config(string IPAddress, int Port)
        {
            this._IPAddress = IPAddress;
            this._Port = Port;
        }
        #endregion Network objects

        /// <summary>
        /// Start server socket
        /// </summary>
        public void Start()
        {
            ClientSocket = new TcpClient(AddressFamily.InterNetwork);
            ClientSocket.Connect(this.IPAddress, this.Port);
            this._isOpen = true;

            Received();
        }

        /// <summary>
        /// Close port
        /// </summary>
        public void Stop()
        {
            if (ClientSocket.Connected)
                ClientSocket.Close();

            this._isOpen = false;
        }

        /// <summary>
        /// If connection is stop then start it, else stop.
        /// </summary>
        public void Toggle()
        {
            if (this.isOpen)
                Stop();
            else
                Start();
        }

        /// <summary>
        /// Function to receive message from client
        /// </summary>
        public async void Received()
        {
            NetworkStream networkStream = ClientSocket.GetStream();
            while (this.isOpen)
            {
                try
                {
                    byte[] bytesFrom = new byte[65536];
                    await networkStream.ReadAsync(bytesFrom, 0, (int)ClientSocket.ReceiveBufferSize);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("\0"));

                    if (dataFromClient.Trim() != "")
                    {
                        Data d = new Data(((System.Net.IPEndPoint)ClientSocket.Client.RemoteEndPoint).Address.ToString(),
                            dataFromClient, DateTime.Now);
                        OnDataReceived(d);
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
        /// Send message to server
        /// </summary>
        /// <param name="smg">Message to server</param>
        public async void Send(string smg)
        {
            NetworkStream networkStream = ClientSocket.GetStream();
            Byte[] sendBytes = Encoding.ASCII.GetBytes(smg);
            networkStream.Write(sendBytes, 0, sendBytes.Length);
            await Task.Delay(1);
        }
    }
}
