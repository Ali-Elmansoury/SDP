using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class OnlineStore_client
    {
        public static ClothesFactory GetBrand(String brand)
        {
            if (brand == "AE")
            {
                return new AE_Factory();
            }
            else if (brand == "Dior")
            {
                return new Dior_Factory();
            }
            else if (brand == "Chanel")
            {
                return new Chanel_Factory();
            }
            else if (brand == "LV")
            {
                return new LV_Factory();
            }
            else
            {
                return null;
            }
        }
    }
}
