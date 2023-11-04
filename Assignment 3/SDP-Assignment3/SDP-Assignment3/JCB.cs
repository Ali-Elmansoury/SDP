using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class JCB : I_PaymentCardProcessor
    {
        public void identifier()
        {
            Console.WriteLine("Identifier: Starts with '3528' to '3589'. JCB cards can have 16 digits.");
        }

        public void usedByBank()
        {
            Console.WriteLine("Used by: JCB is its own card network, primarily issued in Asian countries with some partnerships with international banks.");
        }
    }
}
