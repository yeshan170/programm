using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_6_Q_2
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Enter the size of the first array: ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter a number for the first array: ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] array2 = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter a number for the second array: ");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] array3 = new int[size];

            ArrayOperations.ScalarSum(array1, array2);

            ArrayOperations.VectorSum(array1, array2, array3);

            ArrayOperations.VectorProduct(array1, array2, array3);

            ArrayOperations.ScalarProduct(array1, array2, array3);

        }
    }
}
