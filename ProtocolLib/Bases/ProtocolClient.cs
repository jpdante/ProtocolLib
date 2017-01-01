using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolLib
{
    public abstract class ProtocolClient
    {
        public Socket socket = null;
        public EndPoint remote_endpoint = null;
        public bool async = false;
        public bool server = false;
        public bool encrypt = false;
        public bool compress = false;
        public bool unsafe_protocol = false;
        public byte[] public_key = null;
        public byte[] private_key = null;
        public byte[] authentication_key = null;
        public abstract void inicialize(bool encryption, bool compress, bool async);
        public abstract void connect(IPEndPoint ipendpoint);
        public abstract void disconnect();
        public abstract void listen();
        public abstract void sendPacket(Packet packet);
        public abstract void sendByteArray(byte[] data);
        public abstract void authenticate();
        public abstract int getResponseTime();
        public abstract bool isClient();
        public abstract bool isServer();
        public abstract bool isAsync();
    }
}
