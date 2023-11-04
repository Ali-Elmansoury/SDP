using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class American_Express : I_PaymentCardProcessor
    {
        public void identifier()
        {
            Console.WriteLine("Identifier: Starts with '34' or '37'. American Express cards typically have 15 digits.");
        }

        public void usedByBank()
        {
            Console.WriteLine("Example Banks: American Express Bank, USAA, Wells Fargo, and some smaller issuers.");
        }
    }
}
