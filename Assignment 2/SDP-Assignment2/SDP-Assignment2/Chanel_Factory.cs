using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class Chanel_Factory : ClothesFactory
    {
        public Pants createPants()
        {
            return new Chanel_Pants();
        }

        public Jacket createJacket()
        {
            return new Chanel_Jacket();
        }

        public Shirt createShirt()
        {
            return new Chanel_Shirt();
        }
    }
}
