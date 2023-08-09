/*Q35*/
var solution = new Solution();


public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int len = nums.Length;
        if (target < nums[0])
        {
            return 0;
        }
        else if (target > nums[len - 1])
        {
            return len;
        }
        else
        {
            var l = 0; var r = len - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (nums[mid] < target)
                {
                    l = mid + 1;
                }
                else
                    r = mid - 1;
            }
            return l;
        }
    }
}