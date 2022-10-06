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
/*IsPalindrome*/
namespace Ispalindrome;
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        else
        {
            var xstr = x.ToString();
            Console.WriteLine(xstr);
            Console.WriteLine(xstr.Reverse().ToString());
            if (xstr == xstr.Reverse().ToString())

                return true;
            else
                return false;
        }
    }
}

class TestClass
{
    static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadKey().ToString());
        // Display the number of command line arguments.
        var test = new Solution();
        bool answer = test.IsPalindrome(x);
        Console.WriteLine(answer);
    }
}