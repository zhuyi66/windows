using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime100
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isPrime = new bool[101];
            for (int i = 0; i <= 100; i++)
                isPrime[i] = true;
            isPrime[0] = false;
            isPrime[1] = false;
            Console.WriteLine("质数：");
            try
            {
                for (int i = 2; i <= 100; i++)
                {
                    if (isPrime[i])
                    {
                        for (int j = 2 * i; j <= 100; j += i)
                        {
                            isPrime[j] = false;
                        }
                    }
                    if (isPrime[i])
                        Console.Write(i.ToString() + " ");
                }
            }
            catch
            {
            }
        }
    }
}
