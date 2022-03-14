class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int result = 0;
        
        for(int i = a.Max(); i < b.Min() + 1; i++){
            bool isFactorMultiple = true;
           
            
            foreach(var ele in a){
                if(i % ele != 0) {
                    isFactorMultiple = false;
                    break;
                }
            }
            
            foreach(var ele in b){
                if(ele % i != 0) {
                    isFactorMultiple = false;
                    break;
                }
            }
            
            if(isFactorMultiple){
                result += 1;
            }
        }
        
        return result;
    }

}
