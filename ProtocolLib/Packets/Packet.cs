using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolLib
{
    [Serializable]
    public class Packet
    {
        private byte ID;
        private object Data;

        public Packet() { }

        public Packet(byte id, object data)
        {
            this.ID = id;
            this.Data = data;
        }

        public Packet(byte id)
        {
            this.ID = id;
        }

        public object getData()
        {
            return this.Data;
        }

        public byte getID()
        {
            return this.ID;
        }

        public void setData(object data)
        {
            this.Data = data;
        }

        public void setID(byte id)
        {
            this.ID = id;
        }
    }
}
