class Result
{

    /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        List<int> sums = new List<int>();
        
        for(int row = 1; row < arr.Count - 1; row++){ // Accessing first row
            
            for(int col = 1; col < arr.Count - 1; col++){ // Accessing column
                
                // Adding total of hourglass
                int sum = arr[row - 1][col -1]  + arr[row - 1][col] + arr[row - 1][col + 1]
                                            + arr[row][col]     +
                          arr[row + 1][col - 1] + arr[row + 1][col] + arr[row + 1][col + 1];
                sums.Add(sum);
            }
        }
        
        return sums.Max();
    }
    
}
