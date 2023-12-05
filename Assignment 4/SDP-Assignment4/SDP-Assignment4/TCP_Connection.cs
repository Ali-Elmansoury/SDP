using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment4
{
    internal class TCP_Connection
    {
        private I_TCP_State currentState;

        public TCP_Connection()
        {
            currentState = new Closed_State();
        }

        public void Open()
        {
            currentState.Open(this);
        }

        public void Close()
        {
            currentState.Close(this);
        }

        public void Establish()
        {
            currentState.Establish(this);
        }

        public void Listen()
        {
            currentState.Listen(this);
        }

        public void ChangeState(I_TCP_State newState)
        {
            currentState = newState;
        }
    }
}
