using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_05_Q_2
{
    internal class CalculateValues
        private void sayHello()
        {
            Console.WriteLine("Hello World!");
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
    internal class CalculateValues
        private void sayHello()
    {
        Console.WriteLine("Hello World!");
    }
}
}
*/
//No, you cannot access the sayHello() method because it is private. Private methods are only accessible from within the class that they are defined in. In order to access the sayHello() method, you would need to make it public.