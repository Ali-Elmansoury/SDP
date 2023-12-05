using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment4
{
    internal class Established_State : I_TCP_State
    {
        public void Open(TCP_Connection context)
        {
            Console.WriteLine("Connection is already established\n");
        }

        public void Close(TCP_Connection context)
        {
            Console.WriteLine("Closing connection...\n");
            context.ChangeState(new Closed_State());
        }

        public void Establish(TCP_Connection context)
        {
            Console.WriteLine("Connection is already established\n");
        }

        public void Listen(TCP_Connection context)
        {
            Console.WriteLine("Cannot listen, the connection is already established\n");
        }
    }
}
