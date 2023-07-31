using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_04_Q_4___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindValues findValues = new FindValues();
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = findValues.findArea(radius);
            double circumference = findValues.findCircumference(radius);
            Console.WriteLine("The area of the circle is {0}.", area);
            Console.WriteLine("The circumference of the circle is {0}.", circumference);
            Console.ReadKey();
        }
    }
}
