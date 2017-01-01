using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolLib
{
    public class UDProtocol : ProtocolClient
    {
        public override void inicialize(bool encryption, bool compress, bool async)
        {
            base.socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            base.async = async;
            base.encrypt = encryption;
            base.compress = compress;
        }

        public override void connect(IPEndPoint ipendpoint)
        {
            if(base.async)
            {

            }
            base.socket.Connect(ipendpoint);
            authenticate();
        }

        public override void listen()
        {
            base.server = true;
        }

        public override void disconnect()
        {
            if (base.async)
            {
                //base.socket.DisconnectAsync();
                return;
            }
        }

        public override void sendPacket(Packet packet)
        {
            byte[] data = serialize(packet);
            if (data.Length > 2000000000) throw new OutOfMemoryException();
            data = preparedata(data);
            if (base.async)
            {
                //base.socket.SendAsync(data, 0, data.Length, 0, new AsyncCallback(SendCallback), base.socket);
                return;
            }
            //base.socket.Send(data, 0, data.Length);
        }

       

        public byte[] preparedata(byte[] data)
        {
            return data;
        }

        private void preparelargedata(List<byte[]> data)
        {

        }

        public override void sendByteArray(byte[] data)
        {
            data = preparedata(data);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            Socket client = (Socket)ar.AsyncState;
            int bytesSent = client.EndSend(ar);
            //sendDone.Set();
        }

        public byte[] serialize(Packet packet)
        {
            byte[] data;
            using (var ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, packet);
                data = ms.ToArray();
                ms.Close();
                ms.Dispose();
                bf = null;
            }
            return data;
        }

        public override void authenticate()
        {
            sendPacket(new ProtocolLib.Packet(0x2F));
            sendPacket(new ProtocolLib.Packet(0x1A));
            sendPacket(new ProtocolLib.Packet(0x2F));
        }

        public override int getResponseTime()
        {
            throw new NotImplementedException();
        }

        public override bool isClient()
        {
            return base.socket.Connected;
        }

        public override bool isServer()
        {
            return base.server;
        }

        public override bool isAsync()
        {
            return base.async;
        }
    }
}
