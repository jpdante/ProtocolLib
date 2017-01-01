using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolLib
{
    public class TCProtocol : ProtocolClient
    {
        public override void authenticate()
        {
            throw new NotImplementedException();
        }

        public override void connect(IPEndPoint ipendpoint)
        {
            throw new NotImplementedException();
        }

        public override void disconnect()
        {
            throw new NotImplementedException();
        }

        public override int getResponseTime()
        {
            throw new NotImplementedException();
        }

        public override void inicialize(bool encryption, bool compress, bool async)
        {
            throw new NotImplementedException();
        }

        public override bool isAsync()
        {
            throw new NotImplementedException();
        }

        public override bool isClient()
        {
            throw new NotImplementedException();
        }

        public override bool isServer()
        {
            throw new NotImplementedException();
        }

        public override void listen()
        {
            throw new NotImplementedException();
        }

        public override void sendByteArray(byte[] data)
        {
            throw new NotImplementedException();
        }

        public override void sendPacket(Packet packet)
        {
            throw new NotImplementedException();
        }
    }
}
