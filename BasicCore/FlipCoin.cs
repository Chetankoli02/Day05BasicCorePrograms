using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class FlipCoin
    {
        public void Main(string[] args)
        {
            int tailcount = 0, headcount = 0, perOfHead, perOfTail;
            Console.WriteLine("********Flip coin and print percentage**********");
            Console.WriteLine("Enter No. of times you want to flip the coin");
            int NumofCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < NumofCount; i++)
            {
                Random randombj = new Random();
                int randomheadtail = randombj.Next(0, 1);
                if (randomheadtail < 0.5)
                {
                    tailcount++;
                }
                else
                {
                    headcount++;
                }
                Console.WriteLine("------Percentage of Head vs Tail-------");
                perOfHead = headcount / NumofCount * 100;
                Console.WriteLine("Percentage of Head=" + perOfHead);
                perOfTail = tailcount / NumofCount * 100;
                Console.WriteLine("Percentage of Head=" + perOfTail);
            }
        }
    }
}
