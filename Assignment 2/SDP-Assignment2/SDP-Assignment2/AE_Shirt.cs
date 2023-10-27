using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class AE_Shirt : Shirt
    {
        public void Material()
        {
            Console.WriteLine("AE shirts are made of different materials. Choose an option:\n");
            Console.WriteLine("1. Cotton");
            Console.WriteLine("2. Polyester");
            Console.WriteLine("3. Flannel");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("AE shirts are made of cotton.");
                    break;
                case 2:
                    Console.WriteLine("AE shirts are made of polyester.");
                    break;
                case 3:
                    Console.WriteLine("AE shirts are made of flannel.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void Style()
        {
            Console.WriteLine("\nAE shirts are all button-down\n");
        }

        public void CollarType()
        {
            Console.WriteLine("AE shirts have different collar types. Choose an option:\n");
            Console.WriteLine("1. Spread collar");
            Console.WriteLine("2. Point collar");
            Console.WriteLine("3. Button-down collar");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("AE shirts have a spread collar.");
                    break;
                case 2:
                    Console.WriteLine("AE shirts have a point collar.");
                    break;
                case 3:
                    Console.WriteLine("AE shirts have a button-down collar.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

}
