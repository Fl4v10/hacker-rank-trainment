using System.Linq;

namespace Libs.Easy
{
    public class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(int n, int[] ar)
        {
            System.Array.Sort(ar);

            int sortAr = ar.FirstOrDefault(v => v.Equals(n));
            int numberOfCandles = 0;

            if (sortAr == n)
                return numberOfCandles = 1;
            
            for (int i = ar.Length -1; i >= 0; i--)
            {
                int count = 0;
                if (ar[i] < n)
                {
                    int aux = count + ar[i];

                    if (aux == n)
                        return numberOfCandles++;

                    if (aux < n)
                    {
                        numberOfCandles++;
                        count = aux;
                    }
                }
            }

            return numberOfCandles;
        }
    }
}
