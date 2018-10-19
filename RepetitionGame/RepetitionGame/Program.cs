using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace repetition_game
{
    public class repetition_game
    {
        private static void Main(string[] args)
        {
            //System.IO.StreamReader sr;
            //sr = new System.IO.StreamReader(args[0]);
            string[] lines = new string[2];
            string line = null;
            string text = null, result = null;
            int i = 0;

            try
            {
                text = "That whiwhiwhiwhich does not kill us makes us strororororonger.";

                //List<string> reps = new List<string>();

                for (int repLen = 2; repLen < text.Length; ++repLen)
                {
                    for (int strIndex = 0; strIndex < text.Length; )
                    {
                        try
                        {
                            var repPart = text.Substring(strIndex, repLen);
                            string currentRep = null;

                            if (repPart[0] != repPart[1])
                            {
                                for (int strRepIndex = strIndex + repLen; strRepIndex < text.Length; strRepIndex += repLen)
                                {
                                    try
                                    {
                                        var nextRepPart = text.Substring(strRepIndex, repLen);

                                        if (nextRepPart == repPart)
                                        {
                                            if (currentRep == null)
                                                currentRep = repPart;

                                            currentRep += repPart;
                                        }
                                        else
                                            break;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine();
                                    }
                                }
                            }

                            if (currentRep?.Length > 0)
                                strIndex += currentRep.Length + repLen;
                            else
                                ++strIndex;

                            if((result == null) || ((currentRep?.Length ?? 0) > result.Length))
                            {
                                result = currentRep;
                            }

                            if (currentRep != null)
                            {
                                result = currentRep;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            ++strIndex;
                        }
                    }
                }

                //result = reps.OrderBy(arg => arg.Length).Last();
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
            }
        }
    }
}