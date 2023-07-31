using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_6_Q_2
{
    internal class ArrayOperations
    {
        public static void ScalarSum(int[] array1, int[] array2)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                sum2 += array2[i];
            }

            Console.WriteLine("The scalar sum is: {0}", sum1 + sum2);
        }

        public static void VectorSum(int[] array1, int[] array2, int[] array3)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
            }

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine("{0}", array3[i]);
            }
        }

        public static void VectorProduct(int[] array1, int[] array2, int[] array3)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] * array2[i];
            }

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine("{0}", array3[i]);
            }
        }

        public static void ScalarProduct(int[] array1, int[] array2, int[] array3)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] * array2[i];
            }

            int sum = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                sum += array3[i];
            }

            Console.WriteLine("The scalar product is: {0}", sum);
            Console.ReadKey();
        }
    }
}
