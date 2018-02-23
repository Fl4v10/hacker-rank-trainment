namespace Libs.Easy
{
    public class DiagonalDifference
    {
        public static int diagonalDifference(int[][] a)
        {
            int diagonalA = 0;
            int diagonalB = 0;
            for (int i = 0; i < a[i].Length -1; i++)
            {
                for (int j = 0; j < a[j].Length -1; j++)
                {
                    if ((i == j))
                        diagonalA += a[i][j]; 

                    if((i + j) == (a[i].Length -1))
                        diagonalB += a[i][j];
                }
            }

            return diagonalA - diagonalB;
        }
    }
}
