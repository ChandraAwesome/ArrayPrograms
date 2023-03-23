using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns._4B_programs
{
    internal class Duplicate_Elements
    {
        public static void Count()
        {
            //Console.WriteLine("Enter the elements for an Array");
            //string Elements = Console.ReadLine();
            int[] convert = { 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 9, 9, 5, 4 };

            int counts = 0;
            int uncount = 0;

            //char[] convert = Elements.ToCharArray();
            //Console.Write(convert);

            for(int i=0;i<convert.Length;i++) 
            {
                for(int j=i+1;j<convert.Length;j++)
                {
                    if (convert[i] == convert[j])
                    {
                        Console.WriteLine("Duplicate Elements "+convert[i]);
                        counts++;
                        break;
                    }
                    if (convert[i] != convert[j])
                    {
                        Console.WriteLine("unique Elements "+convert[i]);
                        uncount++;
                        break;
                    }
                 
                }
                
            }
            Console.WriteLine("No of Duplicate Elements are : " + counts);
        }
    }
}
