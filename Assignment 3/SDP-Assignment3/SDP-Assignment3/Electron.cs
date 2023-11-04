using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class Electron : I_PaymentCardProcessor
    {
        public void identifier()
        {
            Console.WriteLine("Identifier: Starts with '4026', '417500', '4405', or '4508'. Electron cards can have 16 digits.");
        }

        public void usedByBank()
        {
            Console.WriteLine("Used by: Maestro Electron cards are issued by banks in Europe and may include banks like NatWest (UK) and ING Bank (Netherlands).");
        }
    }
}
