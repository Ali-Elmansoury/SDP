using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class UnionPay : I_PaymentCardProcessor
    {
        public void identifier()
        {
            Console.WriteLine("Identifier: Starts with '62'. UnionPay cards can vary in length.");
        }

        public void usedByBank()
        {
            Console.WriteLine("Used by: UnionPay is a Chinese card network and is issued by various banks in China and internationally.");
        }
    }
}
