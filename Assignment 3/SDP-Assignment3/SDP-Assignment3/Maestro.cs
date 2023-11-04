using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class Maestro : I_PaymentCardProcessor
    {
        public void identifier()
        {
            Console.WriteLine("Identifier: Starts with '5018', '5020', '5038', '5893', '6304', '6759', or '6761'. Maestro cards can have 12 to 19 digits.");
        }

        public void usedByBank()
        {
            Console.WriteLine("Used by: Maestro cards are often issued by banks in Europe and other regions. Examples include Barclays (UK) and Deutsche Bank (Germany).");
        }
    }
}
