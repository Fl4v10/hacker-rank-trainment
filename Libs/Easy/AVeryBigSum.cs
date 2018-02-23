namespace Libs.Easy
{
    public class AVeryBigSum
    {
        public static long aVeryBigSum(int n, long[] ar)
        {
            long aux = 0;
            
            for (int i = 0; i < n; i++)
            {
                aux += ar[i];
            }

            return aux;
        }
    }
}
