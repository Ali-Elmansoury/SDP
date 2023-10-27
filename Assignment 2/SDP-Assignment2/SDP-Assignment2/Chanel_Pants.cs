using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class Chanel_Pants : Pants
    {
        public void Color()
        {
            Console.WriteLine("Chanel pants are available in different colors. Choose an option:\n");
            Console.WriteLine("1. Black");
            Console.WriteLine("2. Navy");
            Console.WriteLine("3. White");
            Console.WriteLine("4. Beige");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Chanel pants are available in black.");
                    break;
                case 2:
                    Console.WriteLine("Chanel pants are available in navy.");
                    break;
                case 3:
                    Console.WriteLine("Chanel pants are available in white.");
                    break;
                case 4:
                    Console.WriteLine("Chanel pants are available in beige.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void HasZipper()
        {
            Console.WriteLine("Chanel pants all have zippers and a top button.");
        }

        public void HasPockets()
        {
            Console.WriteLine("Chanel pants have pockets. Choose an option:\n");
            Console.WriteLine("1. Front pockets");
            Console.WriteLine("2. Back pockets");
            Console.WriteLine("3. Front and back pockets");
            Console.WriteLine("4. No pockets");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Chanel pants have front pockets.");
                    break;
                case 2:
                    Console.WriteLine("Chanel pants have back pockets.");
                    break;
                case 3:
                    Console.WriteLine("Chanel pants have both front and back pockets.");
                    break;
                case 4:
                    Console.WriteLine("Chanel pants have no pockets.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void Size()
        {
            Console.WriteLine("Chanel pants come in different sizes. Choose an option:\n");
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
            Console.WriteLine("Chanel pants are made of embroidered materials.");
        }
    }

}
