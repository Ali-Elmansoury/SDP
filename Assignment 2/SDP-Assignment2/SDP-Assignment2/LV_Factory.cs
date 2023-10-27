using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class LV_Factory : ClothesFactory
    {
        public Pants createPants()
        {
            return new LV_Pants();
        }

        public Jacket createJacket()
        {
            return new LV_Jacket();
        }

        public Shirt createShirt()
        {
            return new LV_Shirt();
        }
    }
}
