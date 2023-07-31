using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_05_Q_2
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            CalculateValues calculateValues = new CalculateValues();

            // The following line will cause a compile-time error because the sayHello() method is private.
            // calculateValues.sayHello();
        }
    }
}
/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_05_Q_2
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            CalculateValues calculateValues = new CalculateValues();

            // The following line will cause a compile-time error because the sayHello() method is private.
             calculateValues.sayHello();
        }
    }
}
*/

