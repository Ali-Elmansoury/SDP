using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class AE_Factory : ClothesFactory
    {
        public Pants createPants()
        {
            return new AE_Pants();
        }

        public Jacket createJacket()
        {
            return new AE_Jacket();
        }

        public Shirt createShirt()
        {
            return new AE_Shirt();
        }
    }
}
