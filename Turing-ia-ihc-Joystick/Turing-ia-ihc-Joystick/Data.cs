using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_ia_ihc_Joystick
{
    public class Data
    {
        /// <summary>
        /// Message's source
        /// </summary>
        public string IPSource { get { return this._IPSource; } }
        string _IPSource;

        /// <summary>
        /// Message to send or receive
        /// </summary>
        public string Message { get { return this._Message; } }
        string _Message;

        /// <summary>
        /// Date time when message was received
        /// </summary>
        public DateTime Time { get { return this._Time; } }
        private DateTime _Time;

        public Data(string IPSource, string Message, DateTime Time)
        {
            this._IPSource = IPSource;
            this._Message = Message;
            this._Time = Time;
        }
    }
}
