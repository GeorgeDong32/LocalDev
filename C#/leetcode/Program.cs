/*Q58*/
var solution = new Solution();
Console.WriteLine(solution.PlusOne(new int[] { 1, 2, 3 }));

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int len = digits.Length;
        for (int i = len - 1; i >= 0; i--)
        {
            digits[i] += 1;
            digits[i] %= 10;
            if (digits[i] != 0)
            {
                return digits;
            }
        }
        int[] temp = new int[len + 1];
        temp[0] = 1;
        return temp;
    }
}