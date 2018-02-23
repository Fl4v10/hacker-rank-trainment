namespace Libs.Easy
{
    public class CompareTheTriplets
    {
        public static int[] Solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int[] aux = new int[2];

            if (Comparison(a0, b0) == "Alice")
            {
                aux[0] = 1;
            }
            else if(Comparison(a2, b2) == "Bob")
            {
                aux[1] = 1;
            }

            if (Comparison(a1, b1) == "Alice")
            {
                aux[0] += 1;
            }
            else if (Comparison(a2, b2) == "Bob")
            {
                aux[1] += 1;
            }

            if (Comparison(a2, b2) == "Alice")
            {
                aux[0] += 1;
            }
            else if (Comparison(a2, b2) == "Bob")
            {
                aux[1] += 1;
            }

            return aux;
        }

        private static string Comparison(int a, int b)
        {
            string winner = string.Empty;

            if (a > b)
                winner = "Alice";

            if (a < b)
                winner = "Bob";

            return winner;
        }
    }
}
