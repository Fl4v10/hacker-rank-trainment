namespace Libs.Easy
{
    public class PlusMinus
    {
        public static decimal[] plusMinus(int[] arr, int n)
        {
            int positives = 0, negatives = 0, zeroes = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    positives += 1;

                if (arr[i] < 0)
                    negatives += 1;

                if (arr[i] == 0)
                    zeroes += 1;
            }

            decimal[] results = new decimal[3];
            results[0] = (decimal)positives / n;
            results[1] = (decimal)negatives / n;
            results[2] = (decimal)zeroes / n;

            return results;
        }
    }
}
