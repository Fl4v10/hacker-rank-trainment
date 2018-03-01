using System;

namespace Libs.Easy
{
    public class Staircase
    {
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string emptySpace = string.Empty;
                string stepBrick = string.Empty;

                for (int j = i; j < (n -1); j++)
                    emptySpace = emptySpace + " ";

                for (int k = 0; k <= i; k++)
                    stepBrick = stepBrick + "#";

                Console.WriteLine(emptySpace + stepBrick);
            }
        }
    }
}
