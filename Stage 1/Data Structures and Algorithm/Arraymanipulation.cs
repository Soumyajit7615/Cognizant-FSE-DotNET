class Result
{

    /*
     * Complete the 'arrayManipulation' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static long arrayManipulation(int n, List<List<int>> queries)
    {
        long[] control = new long[n + 1];
        long a, b, k;
        for (int i = 0; i < queries.Count; i++)
        {
            a = queries[i][0];
            b = queries[i][1];
            k = queries[i][2];
            control[a - 1] += k;
            control[b] -= k;
        }
        long max = long.MinValue;
        long sum = 0;
        for (int i = 0; i < control.Length; i++)
        {
            sum += control[i];
            max = Math.Max(max, sum);
        }
        return max;
    }
}
