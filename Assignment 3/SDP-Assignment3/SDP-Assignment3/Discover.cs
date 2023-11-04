using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class Discover : I_PaymentCardProcessor
    {
        public void identifier()
        {
            Console.WriteLine("Identifier: Starts with '6011', '622126' to '622925', '644' to '649', or '65'. Discover cards can have 16 digits.");
        }

        public void usedByBank()
        {
            Console.WriteLine("Used by: Discover Bank, Bank of America (for some co-branded cards), and other smaller issuers.");
        }
    }
}
