//0.2023033s on RYZEN 5 5600H

bool is_prime(int n)
{
    var result = true;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            result = false;
            break;
        }
    }
    return result;
}

int count_primes(int n)
{
    var count = 0;
    for (int i = 2; i < n; i++)
    {
        if (is_prime(i))
        {
            count++;
        }
    }
    return count;
}

DateTime dt1 = System.DateTime.Now;

Console.WriteLine($"There are {count_primes(1000000)} primes less than {100000}.");
DateTime dt2 = System.DateTime.Now;

TimeSpan ts = dt2.Subtract(dt1);
Console.WriteLine("example time {0}", ts.TotalSeconds);