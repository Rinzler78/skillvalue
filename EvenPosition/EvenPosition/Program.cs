using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EvenNumbersProblem
{
    public class EvenPosition
    {
        static void Main(string[] args)
        {
            string result = "";
            int[] arrayOfInt = null;
            int resultInt = 0;
            try
            {
                //var sr = new System.IO.StreamReader(args[0]);
                //string[] array = sr.ReadLine().Split(',');
                //arrayOfInt = new int[array.Length];
                //for (int i = 0; i < array.Length; i++) 
                    //arrayOfInt[i] = int.Parse(array[i]);

                arrayOfInt = new int[] { 9, 31, 38, 5, 62, 44, 38, 17, 19, 38, 50, 74 };

                for (int i = 1; i < arrayOfInt.Length; i += 2)
                {
                    var value = arrayOfInt[i];

                    if (IsPrimeNumber(value))
                    {
                        if (resultInt == 0)
                            resultInt = value;
                        else if (value < resultInt)
                            resultInt = value;
                        else
                            break;
                    }
                }

                result = resultInt == 0 ? "NULL" : resultInt.ToString();

                Console.WriteLine("{0}", result);
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
            }
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