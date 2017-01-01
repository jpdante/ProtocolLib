using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolLib.Packets
{
    [Serializable]
    public class ResponseTime
    {
        public int ID;
        public byte[] RandomData;
    }
}
