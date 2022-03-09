class Result
{

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> rotateLeft(int d, List<int> arr)
    {
        for(int i = 0; i<d; i++){
            int temp = arr[0];
            for(int j = 0; j < arr.Count - 1; j++){
                arr[j] = arr[j + 1];
            }
            arr[arr.Count - 1] = temp;
        }   
        return arr;
    }
}
