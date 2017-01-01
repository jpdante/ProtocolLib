using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolLib
{
    [Serializable]
    public class SplitedPacket
    {
        private int ID;
        private int Length;
        private int Session;
        private byte[] Data;
    }
}
