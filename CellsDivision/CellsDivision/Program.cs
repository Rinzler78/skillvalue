using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CellDivision
{
    public class CellDivisionClass
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader sr;
            int inputValue;
            decimal result = 0;
            try
            {
                //sr = new System.IO.StreamReader(args[0]);
                inputValue = 4;//int.Parse(sr.ReadLine());

                //int precCross = 0;
                //int cross = 0;

                for (int i = 0; i < inputValue; ++i)
                    result = i + result;

                result = inputValue + result + 1;

                Console.WriteLine("{0}", result);
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
            }
        }
    }
}
