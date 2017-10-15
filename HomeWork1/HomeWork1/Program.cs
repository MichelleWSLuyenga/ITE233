using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            do
            {
                Console.Write("Enter level of pyramid (enter -1 to exit): ");
                num = Convert.ToInt16(Console.ReadLine());

                if(num != -1)
                {
                    for(int i = 1; i <= num; i++)
                    {
                        for(int j = 1; j <= i; j++)
                        {
                            Console.Write(" ");
                        }
                        for(int n = num; n >= i; n--)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                }else
                {
                    Console.WriteLine("Thank you!");
                }

            } while (num != -1);

            Console.ReadKey();
        }
    }
}
