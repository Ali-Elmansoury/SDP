using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class Dior_Factory : ClothesFactory
    {
        public Pants createPants()
        {
            return new Dior_Pants();
        }

        public Jacket createJacket()
        {
            return new Dior_Jacket();
        }

        public Shirt createShirt()
        {
            return new Dior_Shirt();
        }
    }
}
