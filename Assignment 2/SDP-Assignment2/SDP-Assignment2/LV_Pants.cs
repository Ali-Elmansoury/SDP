using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class LV_Pants : Pants
    {
        public void Color()
        {
            Console.WriteLine("LV pants are available in different colors. Choose an option:\n");
            Console.WriteLine("1. Black");
            Console.WriteLine("2. Brown");
            Console.WriteLine("3. Grey");
            Console.WriteLine("4. Tan");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("LV pants are available in black.");
                    break;
                case 2:
                    Console.WriteLine("LV pants are available in brown.");
                    break;
                case 3:
                    Console.WriteLine("LV pants are available in grey.");
                    break;
                case 4:
                    Console.WriteLine("LV pants are available in tan.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void HasZipper()
        {
            Console.WriteLine("LV pants all have zippers and a top button.");
        }

        public void HasPockets()
        {
            Console.WriteLine("LV pants have pockets. Choose an option:\n");
            Console.WriteLine("1. Front pockets");
            Console.WriteLine("2. Back pockets");
            Console.WriteLine("3. Front and back pockets");
            Console.WriteLine("4. No pockets");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("LV pants have front pockets.");
                    break;
                case 2:
                    Console.WriteLine("LV pants have back pockets.");
                    break;
                case 3:
                    Console.WriteLine("LV pants have both front and back pockets.");
                    break;
                case 4:
                    Console.WriteLine("LV pants have no pockets.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void Size()
        {
            Console.WriteLine("LV pants come in different sizes. Choose an option:\n");
            Console.WriteLine("1. Small");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Large");
            Console.WriteLine("4. XL");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You've chosen Small size.");
                    break;
                case 2:
                    Console.WriteLine("You've chosen Medium size.");
                    break;
                case 3:
                    Console.WriteLine("You've chosen Large size.");
                    break;
                case 4:
                    Console.WriteLine("You've chosen XL size.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void Material()
        {
            Console.WriteLine("LV pants are made of faux leather.");
        }
    }

}
