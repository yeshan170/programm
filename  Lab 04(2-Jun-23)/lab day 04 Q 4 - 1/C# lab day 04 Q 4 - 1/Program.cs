using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_04_Q_4___1
{
    internal class FindValues
    {
        public double findArea(double radius)
        {
            double pi = 3.14159;
            double area = pi * radius * radius;
            return area;
        }
        public double findCircumference(double radius)
        {
            double pi = 3.14159;
            double circumference = 2 * pi * radius;
            return circumference;
        }
    }
}
