using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace SmallerPrimes
{
    public class SmallerPrimes
    {
        static void Main(string[] args)
        {
            int N = 23;
            int[] result = new int[0];
            //var lines = File.ReadAllLines(args[0]);
            //int.TryParse(lines[0], out N);

            var intList = new List<int>();

            for (int i = 2; i < N; ++i)
            {
                if(IsPrimeNumber(i))
                    intList.Add(i);
            }

            result = intList.ToArray();

            for (int j = 0; j < result.Length; j++)
            {
                Console.Write(result[j]);
                if (j < result.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        static bool IsPrimeNumber(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i < number; ++i)
            {
                if ((number % i) == 0)
                    return false;
            }

            return true;
        }
    }
}