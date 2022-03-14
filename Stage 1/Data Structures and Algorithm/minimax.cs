class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long min = arr[0], max = min, sum = min;
        
        for(int i = 1; i < arr.Count; i++){
            sum += arr[i];
            if(arr[i] < min){
                min = arr[i];
            } 
            if(arr[i] > max){
                max = arr[i];
            }
        }
        Console.WriteLine($"{sum-max} {sum-min}");
    }

}
