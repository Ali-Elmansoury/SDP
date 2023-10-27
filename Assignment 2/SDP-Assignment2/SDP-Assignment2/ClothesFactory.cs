using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    interface ClothesFactory
    {
        public Pants createPants();

        public Jacket createJacket();

        public Shirt createShirt();
    }
}
