/*A+B*/
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
}