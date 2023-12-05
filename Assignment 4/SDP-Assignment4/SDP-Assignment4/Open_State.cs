using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment4
{
    internal class Open_State : I_TCP_State
    {
        public void Open(TCP_Connection context)
        {
            Console.WriteLine("Connection is already open\n");
        }

        public void Close(TCP_Connection context)
        {
            Console.WriteLine("Closing connection...\n");
            context.ChangeState(new Closed_State());
        }

        public void Establish(TCP_Connection context)
        {
            Console.WriteLine("Establishing connection...\n");
            context.ChangeState(new Established_State());
        }

        public void Listen(TCP_Connection context)
        {
            Console.WriteLine("Cannot listen, the connection is already open\n");
        }
    }
}
