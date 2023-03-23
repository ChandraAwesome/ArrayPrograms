using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class SumofGivenNumbers
    {
        public static void Add()
        {
            Console.WriteLine("Enter any Number");
            int N=Convert.ToInt32(Console.ReadLine());
            int sum = 0, remainder;
            
            while(N>0)
            {
                remainder=N%10;
                sum+=remainder;
                N = N / 10;
            }
            Console.WriteLine("Sum of the digits : "+sum); 
        }

        public static void UsingArray() 
        {
            Console.WriteLine("Enter any Number");
            string N = Console.ReadLine();
            int sum = 0;
            char[] numbers = N.ToCharArray();

            int[] Digits = new int[numbers.Length];

            for(int i=0;i<numbers.Length;i++)
            {
                Digits[i] = (int)Char.GetNumericValue(numbers[i]);
            }

            foreach(int num in Digits)
            {
                sum+= num;
            }
            Console.WriteLine("Sum of the digits is :" + sum);
        }
    }
}
