class Result
{

    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int pairsCount = 0;
        
        for(int i = 0; i < n; i++){
            Console.WriteLine(i);
            for(int j = i + 1; j < n; j++){
                // Console.WriteLine(j);
                // Console.Write(ar[i] + ar[j] + " : " + (ar[i] + ar[j]) % k + "\n");
                if((ar[i] + ar[j]) % k == 0){
                    pairsCount += 1;
                }
            }
            Console.WriteLine("-------");
        }
        return pairsCount;
    }

}
