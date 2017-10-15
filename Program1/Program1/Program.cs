using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalWeek = 0;
            while(TotalWeek != 13)
            {
                Console.Write("How many week does stamford has for each semester");
                TotalWeek = Convert.ToInt16(Console.ReadLine());
                if(TotalWeek != 13)
                {
                    Console.WriteLine("Are you sure that you are correct?");
                }
            }
            Console.WriteLine("Stamford Week Countdown");
            for(int i = 1; i <= TotalWeek; i++)
            {
                switch(i)
                {
                    case 6:
                        Console.WriteLine("Time For Midterm Exam!!");
                        break;
                    case 13:
                        Console.WriteLine("Time for Final Exam, I love it!");
                        break;
                    default:
                        Console.WriteLine("Week" + i + " Lecture");
                        break;
                }
            }
            Console.WriteLine("Time for term break! See you again next Semester.");
            Console.ReadKey();
        }
    }
}
