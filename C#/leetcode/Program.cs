using System;
/*A+B
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] re = new int[2]; int start = 0;
        re[0] = 0; re[1] = 0;
        foreach (int num in nums)
        {
            for (int i = start + 1; i < nums.Length; i++)
            {
                if (num + nums[i] == target)
                {
                    re[0] = start;
                    re[1] = i;
                    return re;
                }
            }
            start++;
        }
        return re;
    }
}*/
/*IsPalindrome
namespace Ispalindrome;
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;
        int revertedNumber = 0;
        while (x > revertedNumber)
        {
            revertedNumber = revertedNumber * 10 + x % 10;
            x /= 10;
        }
        return x == revertedNumber || x == revertedNumber / 10;
    }
}*/
/*LongestCommonPrefix
namespace LongestCommonPrefix;
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs. == 0)
        {
            return "";
        }
        int length = strs[0].Length;
        int count = strs.Length;
        for (int i = 0; i < length; i++)
        {
            char c = strs[0][i];
            for (int j = 1; j < count; j++)
            {
                if (i == strs[j].Length || strs[j][i] != c)
                {
                    return strs[0].Substring(0, i);
                }
            }
        }
        return strs[0];
    }
}*/
/*IsValid*/
namespace IsValid;
public class Solution
{
    public bool IsValid(string s)
    {
        var len = s.Length;
        // 字符串长度为单数，直接返回`false`
        if (len % 2 == 1)
            return false;
        // 初始化栈
        var stack = new Stack<char>();
        for (int i = 0; i < len; i++)
        {
            // 遍历字符串中字符，当字符为左括号时，进栈对应右括号
            if (s[i] == '(')
                stack.Push(')');
            else if (s[i] == '[')
                stack.Push(']');
            else if (s[i] == '{')
                stack.Push('}');
            // 如果字符是右括号时
            else
                // 当栈为空或出栈字符不等于当前字符返回false
                if (stack.Count == 0 || stack.Pop() != s[i])
                return false;
        }
        // 如果栈不为空，例如“((()”，返回false
        if (stack.Count > 0)
            return false;
        // 上面的校验都满足，则返回true
        else
            return true;
    }
}

/*TestMain*/
class TestClass
{
    static void Main(string[] args)
    {
        bool answer = false;
        var test = new Solution();
        answer = test.IsValid("(){()}[]");
        Console.WriteLine(answer);
    }
}