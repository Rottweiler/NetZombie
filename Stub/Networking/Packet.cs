using System;
using System.IO;

namespace Stub.Networking
{
    /// <summary>
    /// A very simple packet class, for reading/writing data over a network
    /// Read 8 bytes (long) and parse to get the size of the payload
    /// </summary>
    public class Packet
    {
        /// <summary>
        /// Parse a packet from byte array
        /// </summary>
        /// <param name="data"></param>
        /// <returns>A packet instance</returns>
        public static Packet Parse(byte[] data)
        {
            byte[] headerSz = new byte[sizeof(long)];
            byte[] typeSz = new byte[sizeof(long)];
            using (MemoryStream ms = new MemoryStream(data))
            {
                ms.Read(headerSz, 0, sizeof(long));
            }

            long payloadSize = BitConverter.ToInt64(headerSz, 0);
            byte[] payloadSz = new byte[payloadSize];
            using (MemoryStream ms = new MemoryStream(data))
            {
                ms.Read(headerSz, 0, sizeof(long));
                ms.Read(typeSz, 0, sizeof(long));
                ms.Read(payloadSz, 0, payloadSz.Length);
            }

            return new Packet() { Payload = payloadSz, Type = BitConverter.ToInt64(typeSz, 0) };
        }

        /// <summary>
        /// Serializes the packet
        /// </summary>
        /// <returns></returns>
        public byte[] ToArray()
        {
            byte[] headerSz = BitConverter.GetBytes(Payload.LongLength);
            byte[] typeSz = BitConverter.GetBytes(Type);
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(headerSz, 0, headerSz.Length);
                ms.Write(typeSz, 0, typeSz.Length);
                ms.Write(Payload, 0, Payload.Length);
                return ms.ToArray();
            }

        }

        /// <summary>
        /// Packet's payload data
        /// </summary>
        public byte[] Payload;

        /// <summary>
        /// Packet's type
        /// </summary>
        public long Type;

        public Packet() { }

        public Packet(long type, byte[] data)
        {
            this.Type = type;
            this.Payload = data;
        }
    }
}
