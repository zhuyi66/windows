using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("请输入一个正整数：");
            number = int.Parse(Console.ReadLine());
            try
            {
                findPrime(number);
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
        }
        private static void findPrime(int number)
        {
            int primeCount = 0;
            Console.WriteLine("素数因子：");
            for (int i = 1; i <= number; i++)
            {
                bool judge = true;
                if ((number / i) * i - number != 0)
                    continue;
                if (i == 1)
                    judge = false;
                for (int k = 2; k <= i / 2; k++)
                {
                    if (i % k == 0)
                        judge = false;
                }
                if (judge)
                {
                    Console.Write(i);
                    Console.Write('\0');
                    primeCount++;
                    if (primeCount % 10 == 0)
                        Console.WriteLine('\n');
                }
            }
        }
    }
}
