using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleepy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many day's temperature?");
            int days = Convert.ToInt16(Console.ReadLine());
            int[] eachdaystemp = new int[days];
            double avg = 0;
            //{day, temp}
            int[] hottest = { 0, 0 };
            int[] coldest = { 0, 0 };
            //Console.WriteLine(eachdaystemp.Length);
            //Console.ReadKey();
            for(int i = 0; i < eachdaystemp.Length; i++)
            {
                Console.WriteLine("Day" + i+1 + "'s temp:");
                eachdaystemp[i] = Convert.ToInt16(Console.ReadLine());
                avg += eachdaystemp[i];

                if (i == 0)
                {
                    hottest[0] = i + 1;
                    hottest[1] = eachdaystemp[i];
                    coldest[0] = i + 1;
                    coldest[1] = eachdaystemp[i];
                }
                if(hottest[1] < eachdaystemp[i])
                {
                    hottest[0] = i + 1;
                    hottest[1] = eachdaystemp[i];
                }
                if(coldest[1] > eachdaystemp[i])
                {
                    coldest[0] = i + 1;
                    coldest[1] = eachdaystemp[i];
                }


            }
            avg /= days;


            Console.ReadKey();
        }
    }
}
