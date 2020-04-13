using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MaximumPath
{
    public class MaximumPath
    {
        private static int M, N;
        public static void Main(string[] args)
        {
            args = new string[]{
                "5", "4",
                "2", "9", "3", "6",
                "5", "9", "1", "2",
                "0", "0", "2", "1",
                "4", "6", "8", "3",
                "1", "1", "8", "9"
            };
            //var streamReader = new System.IO.StreamReader(args[0]);
            List<string> lines = args.ToList();
            //string line;
            //while ((line = streamReader.ReadLine()) != null) lines.AddRange(line.Split(' '));
            M = int.Parse(lines[0]);
            N = int.Parse(lines[1]);
            int[,] A = new int[M, N];
            int index = 2;
            int[] matrixLine = new int[M];
            int result = 0;
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    A[i, j] = int.Parse(lines[index++]);

            result = Compute(A, new Tuple<int, int>(0, 0));

            Console.WriteLine("{0}", result);
        }

        public static int Compute(int[,] array, Tuple<int, int> startPosition)
        {
            var xLength = array.GetLength(0) - 1;
            var yLength = array.GetLength(1) - 1;

            if (startPosition.Item1 <= xLength && startPosition.Item2 <= yLength)
            {
                var result = array[startPosition.Item1, startPosition.Item2];

                var rightCompute = startPosition.Item1 < xLength ? Compute(array, new Tuple<int, int>(startPosition.Item1 + 1, startPosition.Item2)) : 0;
                var bottomCompute = startPosition.Item2 < yLength ? Compute(array, new Tuple<int, int>(startPosition.Item1, startPosition.Item2 + 1)) : 0;

                result += rightCompute > bottomCompute ? rightCompute : bottomCompute;

                return result;
            }

            return -1;
        }
    }
}