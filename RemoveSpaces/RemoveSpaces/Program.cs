using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace remove_spaces
{
    public class remove_spaces
    {
        private static void Main(string[] args)
        {
            //System.IO.StreamReader sr;
            //sr = new System.IO.StreamReader(args[0]);

            string line = null;
            string A = null;
            string result = null;

            try
            {
                A = "I   live   on     earth.";

                result = string.Join(" ", A.Split(' ').Where(arg => arg.Length > 0));
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
            }
        }
    }
}