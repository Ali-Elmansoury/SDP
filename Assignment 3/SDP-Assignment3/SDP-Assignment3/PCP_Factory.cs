using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Assignment3
{
    internal class PCP_Factory : I_PCP_Factory
    {
        public I_PaymentCardProcessor getData(string cardType)
        {
            I_PaymentCardProcessor pcp;
            switch (cardType)
            {
                case "Visa":
                    pcp = new Visa();
                    break;
                case "MasterCard":
                    pcp = new Mastercard();
                    break;
                case "AmericanExpress":
                    pcp = new American_Express();
                    break;
                case "Discover":
                    pcp = new Discover();
                    break;
                case "DinersClub":
                    pcp = new Diners_Club_International();
                    break;
                case "JCB":
                    pcp = new JCB();
                    break;
                case "UnionPay":
                    pcp = new UnionPay();
                    break;
                case "Maestro":
                    pcp = new Maestro();
                    break;
                case "Electron":
                    pcp = new Electron();
                    break;
                case "Meeza":
                    pcp = new Meeza();
                    break;
                default:
                    pcp = null;
                    break;
            }
            return pcp;
        }
    }
}
