using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_05_Q_3
{
    internal class ArrayUtils
    {
        public static int Min(int[] arr)
        {
            int minValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]<minValue)
                {
                    minValue = arr[i];
                }
            }
            return minValue;
        }
        public static int Max(int[] arr)
        { 
            int maxValue = arr[0];
            for (int i=1;i<arr.Length;i++)
            {
                if (arr[i]>maxValue)
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }
        public static float Average(int[] arr)
        {
            int sum = 0;
            for (int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
        public static int[] Reverse(int[] arr)
        {
            int[] reversedArr = new int[arr.Length];
            for (int i = 0, j = arr.Length - 1; i < arr.Length; i++,j--)
                {
                reversedArr[i] = arr[i];
                }
            return reversedArr;
        }
    }
}
