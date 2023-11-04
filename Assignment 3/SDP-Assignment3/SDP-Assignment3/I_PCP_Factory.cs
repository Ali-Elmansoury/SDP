using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal interface I_PCP_Factory
    {
        public I_PaymentCardProcessor getData(string cardType);
    }
}
