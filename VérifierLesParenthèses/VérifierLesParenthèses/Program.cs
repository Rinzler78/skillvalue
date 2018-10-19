using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace check_parentheses
{
    public class check_parentheses
    {
        private static void Main(string[] args)
        {
            //System.IO.StreamReader sr;
            //sr = new System.IO.StreamReader(args[0]);
            string[] lines = new string[10];
            string line = null;
            string text = "(2×3) + 4)";
            int i = 0;
            int result = -1;
            try
            {
                //while ((line = sr.ReadLine()) != null) lines[i++] = line;
                //for (int j = 0; j < lines.Length; j++)
                //{
                //    text += lines[j];
                //}

                int p = 0, c = 0, a = 0;

                foreach(var car in text)
                {
                    switch(car)
                    {
                        case '(':
                            ++p;
                            break;
                        case ')':
                            --p;
                            break;
                        case '[':
                            ++c;
                            break;
                        case ']':
                            --c;
                            break;
                        case '{':
                            ++a;
                            break;
                        case '}':
                            --a;
                            break;
                    }
                }

                result = (p + c + a) == 0 ? 1 : 0;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
            }
        }
    }
}