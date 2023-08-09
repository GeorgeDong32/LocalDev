/*Q35*/
var solution = new Solution();


public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target)
                return i;
        }
        return nums.Length;
    }
}