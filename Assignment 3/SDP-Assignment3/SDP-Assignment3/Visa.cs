using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class Visa : I_PaymentCardProcessor
    {
        public void identifier()
        {
            Console.WriteLine("Identifier: Starts with a '4'. Visa cards typically have 16 digits.");
        }

        public void usedByBank()
        {
            Console.WriteLine("Used by: Bank of America, JPMorgan Chase, Wells Fargo, Citibank, Capital One, and many others.");
        }
    }
}
