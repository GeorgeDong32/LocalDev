/*Q58*/
var solution = new Solution();
Console.WriteLine(solution.LengthOfLastWord("  Test Helllo     "));

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        var len = s.Length; var count = 0;
        for (var i = len - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                count++;
            }
            else
            {
                return count;
            }
        }
        return count;
    }
}