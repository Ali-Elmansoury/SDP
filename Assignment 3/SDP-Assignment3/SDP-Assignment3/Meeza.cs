using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class Meeza : I_PaymentCardProcessor
    {
        public void identifier()
        {
            Console.WriteLine("Identifier: Starts with '50'. Meeza cards typically have 16 digits.");
        }

        public void usedByBank()
        {
            Console.WriteLine("Used by: Various banks and financial institutions in Egypt.");
        }
    }
}
