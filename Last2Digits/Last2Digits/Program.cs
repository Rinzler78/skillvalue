using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Last2Digits
{
    public class Last2DigitsClass
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader sr;
            int a, b;
            int result = -1;
            try
            {
                a = 10;
                b = 11;

                var resStr = (a * b).ToString();

                int.TryParse(resStr.Substring(resStr.Length - 2, 2), out result);

                Console.WriteLine("{0}", result);
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
            }
        }
    }
}
