using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment4
{
    internal class Listening_State : I_TCP_State
    {
        public void Open(TCP_Connection context)
        {
            Console.WriteLine("Cannot open, the connection is already listening\n");
        }

        public void Close(TCP_Connection context)
        {
            Console.WriteLine("Stopping listening...\n");
            context.ChangeState(new Closed_State());
        }

        public void Establish(TCP_Connection context)
        {
            Console.WriteLine("Establishing connection from listening state\n");
            context.ChangeState(new Established_State());
        }

        public void Listen(TCP_Connection context)
        {
            Console.WriteLine("Connection is already listening\n");
        }
    }
}
