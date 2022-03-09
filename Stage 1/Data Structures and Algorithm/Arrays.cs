class Result
{

    /*
     * Complete the 'reverseArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static List<int> reverseArray(List<int> a)
    {
        int length = a.Count;
        for(var i = 0; i < length / 2; i++){
            int temp = a[i];
            a[i] = a[length - i -1];
            a[length - i -1] = temp;
        }   
        return a;
    }
}
