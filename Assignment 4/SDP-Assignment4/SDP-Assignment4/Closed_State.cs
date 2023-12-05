using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment4
{
    internal class Closed_State : I_TCP_State
    {
        public void Open(TCP_Connection context)
        {
            Console.WriteLine("Opening connection...\n");
            context.ChangeState(new Open_State());
        }

        public void Close(TCP_Connection context)
        {
            Console.WriteLine("Connection is already closed\n");
        }

        public void Establish(TCP_Connection context)
        {
            Console.WriteLine("Cannot establish connection, the connection is closed\n");
        }

        public void Listen(TCP_Connection context)
        {
            Console.WriteLine("Cannot listen, the connection is closed\n");
        }
    }
}
