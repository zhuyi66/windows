using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 2, 9, 8, 11, 23, 4, 9, 6, 22, 15, 36, 23, 10 };
            float sum;
            int max;
            int min;
            float average;
            try
            {
                operation(array, out sum, out max, out min, out average);
                Console.WriteLine("最大值=" + max);
                Console.WriteLine("最小值=" + min);
                Console.WriteLine("数组和=" + sum);
                Console.WriteLine("平均值=" + average);
            }
            catch
            {

            }
        }
        private static void operation(int[]array,out float sum,out int max,out int min,out float average)
        {
            sum = 0;
            max = array[0];
            min = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                sum += array[i];
                if (i != 0)
                {
                    if (max < array[i])
                        max = array[i];
                    if (min > array[i])
                        min = array[i];
                }
            }
            average = sum / array.Length;
        }
    }
}
