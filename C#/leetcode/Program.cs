var sol = new Solution();
var test = new int[] { 1, 1, 1, 1, 1, 2 };
Console.WriteLine("{0}  {1}", sol.RemoveDuplicates(test), test);

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var len = nums.Length;
        if (nums.Length == 0)
            return 0;
        var l = 1; var r = 1;
        while (l < len)
        {
            if (nums[l] != nums[l - 1])
            {
                nums[r] = nums[l];
                r++;
            }
            l++;
        }
        return r;
    }
}