namespace Libs.Easy
{
    public class CompareTheTriplets
    {
        public static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int[] aux = new int[2];

            if (Comparison(a0, b0))
            {
                aux[0] = 1;
            }
            else
            {
                aux[1] = 1;
            }

            if (Comparison(a1, b1))
            {
                aux[0] += 1;
            }
            else
            {
                aux[1] += 1;
            }

            if (Comparison(a2, b2))
            {
                aux[0] += 1;
            }
            else if (Comparison(a2, b2))
            {
                aux[1] += 1;
            }

            return aux;
        }

        private static bool Comparison(int a, int b)
        {
            bool winner = false;

            if (a > b)
                winner = true;

            if (a < b)
                winner = false;

            return winner;
        }
    }
}
