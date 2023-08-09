/*Q28*/
var s = new Solution();
var h = "sadbutsad"; var n = "sad";
Console.WriteLine(s.StrStr(h, n));

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        haystack = haystack.Replace(needle, "@");
        for (var i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == '@')
            {
                return i;
            }
        }
        return -1;
    }
}