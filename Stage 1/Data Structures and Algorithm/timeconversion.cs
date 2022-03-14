class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        DateTime outputTime;
        
        bool res = DateTime.TryParseExact(
            s, 
            "hh:mm:sstt", 
            System.Globalization.CultureInfo.InvariantCulture,
            DateTimeStyles.None, 
            out outputTime);
        
        
        return outputTime.ToString("HH:mm:ss");
    }

}
