using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Powerof2
    {
        public void Main(string[] args)
        {
            Console.Write("Enter the value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0 && n < 31)
            {
                Console.WriteLine("Powers of 2:" + n);
            }
            else
            {
                Console.WriteLine("Invalid input. N should be between 0 and 30.");
            }
        }
       
    }
}
