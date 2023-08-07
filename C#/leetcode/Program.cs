public class Solution
{
    public int RomanToInt(string s)
    {
        var result = 0;
        //预处理
        s = s.Replace("IV", "a");
        s = s.Replace("IX", "b");
        s = s.Replace("XL", "c");
        s = s.Replace("XC", "d");
        s = s.Replace("CD", "e");
        s = s.Replace("CM", "f");
        //处理
        for (int i = 0; i < s.Length; i++)
        {
            result += GetValue(s[i]);
        }
        return result;
    }

    public int GetValue(char c)
    {
        switch (c)
        {
            case 'a':
                return 4;
            case 'b':
                return 9;
            case 'c':
                return 40;
            case 'd':
                return 90;
            case 'e':
                return 400;
            case 'f':
                return 900;
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                return 0;
        }
    }
}