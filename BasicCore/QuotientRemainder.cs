using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class QuotientRemainder
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            if (divisor == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return;
            }
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
