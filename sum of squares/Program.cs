using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_squares
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 1; i<=100; i++)
            {
                sum2 = sum2 + i;
                double pow_i = Math.Pow(i, 2);
                sum1 = sum1 + pow_i;
            }
            Console.WriteLine("Sum of the squares of first 100 numbers:  " + sum1);
            double pow_sum2 = Math.Pow(sum2, 2);
            Console.WriteLine("Squares of the sum of first 100 numbers:  " + pow_sum2);
            double difference = Math.Abs(pow_sum2-sum1);
            Console.WriteLine("Differences are:  " + difference);

            Console.ReadKey();
        }
    }
}
