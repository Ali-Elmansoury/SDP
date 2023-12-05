using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment4
{
    internal interface I_TCP_State
    {
        void Open(TCP_Connection context);
        void Close(TCP_Connection context);
        void Establish(TCP_Connection context);
        void Listen(TCP_Connection context);
    }
}
