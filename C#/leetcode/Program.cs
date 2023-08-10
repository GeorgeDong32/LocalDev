/*Q67*/
var solution = new Solution();
Console.WriteLine(solution.AddBinary("111", "10"));

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var ml = a.Length > b.Length ? a.Length : b.Length;
        var result = ""; var carry = 0;
        if (a.Length != ml)
        {
            for (var i = a.Length; i < ml; i++)
            {
                a = "0" + a;
            }
        }
        else if (b.Length != ml)
        {
            for (var i = b.Length; i < ml; i++)
            {
                b = "0" + b;
            }
        }
        for (var i = ml - 1; i >= 0; i--)
        {
            var mid = 0;
            if (a[i] == '1' && b[i] == '1')
            {
                mid = 0 + carry;
                carry = 1;
            }
            else if ((a[i] == '1' && b[i] == '0') || (b[i] == '1' && a[i] == '0'))
            {
                mid = (1 + carry) % 2;
                carry = (1 + carry) / 2;
            }
            else
            {
                mid = carry;
                carry = 0;
            }
            result = ((mid == 1) ? "1" : "0") + result;
        }
        if (carry == 1)
            result = "1" + result;
        return result;
    }
}