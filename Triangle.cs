using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Triangle
    {
        public static void RightAngleTriangle()
        {
            Console.WriteLine("Enter the number of lines");
            int n= Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=n;i++) 
            {
                for (int j=1;j<=i;j++) 
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void ReverseAngleTriangle() 
        {
            Console.WriteLine("Enter the number of lines");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=n;i>=1;i--)
                {
                { 
                for(int j=1;j<=i;j++)
                    Console.Write("*");
                }
            Console.WriteLine();
            }
        }

        public static void EquiTringle()
        {
            Console.WriteLine("Enter the number of lines");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }

                for(int k=1;k<(i*2);k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static void ReverseEqiTriangle()
        {
            Console.WriteLine("Enter the number of lines");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i =n; i >=1; i--)
            {
                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
