using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_03_Q_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = number; i > 0; i /= 10)
            {
                int digit = i % 10;
                sum += digit;
            }
            Console.WriteLine("The sum of the digits of the number is: {0}", sum);
            Console.ReadKey();
        }
    }
}
