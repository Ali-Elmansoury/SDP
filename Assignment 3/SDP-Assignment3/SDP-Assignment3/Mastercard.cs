using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class Mastercard  : I_PaymentCardProcessor
    {
        public void identifier()
        {
            Console.WriteLine("Identifier: Starts with '51' to '55' or '2221' to '2720'. MasterCard cards typically have 16 digits.");
        }

        public void usedByBank()
        {
            Console.WriteLine("Used by: Bank of Montreal (BMO), TD Bank, Capital One, HSBC, Citibank, and many others.");
        }
    }
}
