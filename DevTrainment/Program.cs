using Libs.Easy;
using System;

namespace DevTrainment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = CompareTheTriplets.Solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));

            Console.ReadKey();
        }

        static void Main2(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = AVeryBigSum.aVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
    }
}
