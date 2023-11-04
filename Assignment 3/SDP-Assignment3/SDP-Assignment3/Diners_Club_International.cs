using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class Diners_Club_International : I_PaymentCardProcessor
    {
        public void identifier()
        {
            Console.WriteLine("Identifier: Starts with '36' or '38'. Diners Club International cards can have 14 digits.");
        }

        public void usedByBank()
        {
            Console.WriteLine("Used by: Diners Club International is its own card network, and various financial institutions issue Diners Club cards.");
        }
    }
}
