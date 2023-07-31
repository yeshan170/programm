using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_05_Q_3
{
    internal class Class1
    {
        static void Main(string[] args)
        { int[] arr = new int[10];
            Console.WriteLine("Enter the values of the array:");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int minValue = ArrayUtils.Min(arr);
            int maxValue = ArrayUtils.Max(arr);
            float average = ArrayUtils.Average(arr);
            int[] reversedArr = ArrayUtils.Reverse(arr);

            Console.WriteLine("The minimum value is {0}", minValue);
            Console.WriteLine("The maximum value is {0}", maxValue);
            Console.WriteLine("The average value is {0}", average);
            Console.WriteLine("The reversed array is {0}", reversedArr);
            Console.ReadKey();
        }
    }
}
