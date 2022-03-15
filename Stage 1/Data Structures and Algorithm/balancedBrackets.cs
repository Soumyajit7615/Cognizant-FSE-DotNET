class Result
{

    /*
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        Dictionary<char, char> pairsOfBrackets = new Dictionary<char, char>()
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'},
        };

        Stack<char> dustBin = new Stack<char>();

        /*
         * Check whether the string with end brackets
         * if it starts end symbol, it'll not be balanced one.
         * So, return "NO"
         */
        if (pairsOfBrackets.ContainsValue(s[0]))
            return "NO";
        
        /*
         * Here we check the string length is even or not
         * if it odd then we conclude at-least one pair of bracket is not balanced
         * So, return "NO"
         */
        if (s.Length % 2 != 0)
            return "NO";
        
        /*
         * Loop into the string and check it is balanced or not
         */
        foreach (var c in s)
        {
            if (pairsOfBrackets.ContainsKey(c))
            {
                dustBin.Push(c);
            }
            else
            {
                if (!pairsOfBrackets.ContainsValue(c)) continue;
                if (dustBin.Count != 0 && c == pairsOfBrackets[dustBin.First()])
                    dustBin.Pop();
                else
                    return "NO";
            }
        }

        return dustBin.Count == 0 ? "YES" : "NO";
    }

}
