using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Swapping
    {
        public void Main(string[] args)
        {

            Console.WriteLine("Enter the First Number");
            Console.WriteLine("Enter the Second Number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping");
            Console.WriteLine("First Number: " + number1);
            Console.WriteLine("Second Number: " + number2);

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("After swapping:");
            Console.WriteLine("First number: " + number1);
            Console.WriteLine("Second number: " + number2);
        }
    }
}
