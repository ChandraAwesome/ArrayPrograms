using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class ReverseaNumber
    {
        public static void ReverseusingChar()
        {
            Console.WriteLine("Enter the number");
            string n = Console.ReadLine();

            char[] number = n.ToCharArray();
            Array.Reverse(number);

            Console.WriteLine(number);
        }

        public static void Reverseusingloop()
        {
            Console.WriteLine("Enter the number");
            string n= Console.ReadLine();
          
            char[] number = n.ToCharArray();

            for(int i=n.Length-1; i>=0; i--) 
            {
                Console.Write(number[i]);
            }

        }
    }
}
