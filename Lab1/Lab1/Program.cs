using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, mat;
            int num = 0;

            Console.Write("Enter the first number: ");
            first = Convert.ToInt16(Console.ReadLine());

            do
            {
                Console.Write(" \"1\" to add \"2\" to minus \"-1\" to exit: ");
                mat = Convert.ToInt16(Console.ReadLine());

                switch (mat)
                {
                    case 1:
                        Console.Write("Enter number to add the value: ");
                        num = Convert.ToInt16(Console.ReadLine());
                        num = first += num;
                        Console.WriteLine("Your current result is " + num);
                        break;
                    case 2:
                        Console.Write("Enter number to minus the value: ");
                        num = Convert.ToInt16(Console.ReadLine());
                        num = first -= num;
                        Console.WriteLine("Your current result is " + num);
                        break;
                    default:
                        Console.WriteLine("Your current result is " + num);
                        break;
                }

            } while (mat != -1);

            Console.ReadKey();
        }
    }
}
