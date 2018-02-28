using System.Linq;

namespace Libs.Easy
{
    public class Mini_MaxSum
    {
        public static void miniMaxSum(int[] arr)
        {
            long max = arr.Max();
            long min = arr.Min();

            long maxSum = - min;
            long miniSum = - max;

            for (int i = 0; i < arr.Length; i++)
            {
                maxSum += arr[i];
                miniSum += arr[i];
            }

            System.Console.WriteLine(miniSum + " " + maxSum);
        }
    }
}
