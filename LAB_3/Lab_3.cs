namespace LAB_3
{
    internal class Lab_3
    {
        public void calculate()
        {
            int[] S = { 4, 2, 3, 1 };
            int[][] M = new int[S.Length][];
            int maxCol = maxValueOfS(S);
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = new int[S[i]];
            }
            int[][] E = new int[S.Length][];
                Random random = new Random();
            for (int i = 0; i < E.Length; i++)
            {
                E[i] = new int[S[i]];
                for (int j = 0; j < S[i]; j++)
                {
                    E[i][j] = random.Next(3, 10);
                }
            }
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = 0; j < S[i]; j++)
                {
                    M[i][j] = E[i][j];
                }
            }
            int maxRow = IndexOfMaxRow(S);
            for (int i = 0; i < M[maxRow].Length; i++)
            {
                M[maxRow][i] = 0;
            }
            Console.WriteLine("M:");
            for (int i = 0; i < M.Length; i++)
            {
                for (int j = 0; j < M[i].Length; j++)
                {
                    Console.Write($"{M[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        public int IndexOfMaxRow(int[] s)
        {
            int max = s[0];
            int index = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] > max)
                {
                    max = s[i];
                    index = i;
                }
            }
            return index;
        }

        public int maxValueOfS(int[] s)
        {
            int max = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] > max) max = s[i];
            }
            return max;
        }
    }
}
