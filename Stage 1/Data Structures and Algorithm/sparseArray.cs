class Result
{

    /*
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> results = new List<int>(Enumerable.Repeat(0, queries.Count));
        
        for(int i = 0; i < queries.Count; i++){
            for(int j = 0; j < strings.Count; j++){
                if(queries[i] == strings[j]){
                    results[i] += 1;
                }
            }
        }
        return results;
    }

}
