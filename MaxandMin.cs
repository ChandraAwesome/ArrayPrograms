using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns._4B_programs
{
    internal class MaxandMin
    {
        public static void MaximumandMinimum()
        {
            Console.WriteLine("Enter the size of an array");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements of an array");
            int[] Elements = new int[size];

            for(int i=0;i<size;i++)
            {
                Elements[i]=Convert.ToInt32(Console.ReadLine());
            }

            int max = Elements[0];
            int min = Elements[0];

            for(int j=0;j<Elements.Length;j++) 
            {
                if (Elements[j]>max)
                {
                    max= Elements[j];
                }
                if (Elements[j]<min)
                {
                    min= Elements[j];
                }
            }
            Console.WriteLine("The maximum elemets in the array is "+max);
            Console.WriteLine("The minimum elemets in the array is " + min);
        }
    }
}
