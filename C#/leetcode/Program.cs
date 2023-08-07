var solution = new Solution();

Console.WriteLine(solution.IsValid("((((()))))"));
Console.WriteLine(solution.IsValid("{[(())]}"));

public class Solution
{
    public bool IsValid(string s)
    {
        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "");
            s = s.Replace("[]", "");
            s = s.Replace("{}", "");
        }
        return s == "";
    }
}