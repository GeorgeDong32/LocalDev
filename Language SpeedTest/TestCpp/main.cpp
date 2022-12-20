#include <iostream>
#include <windows.h>
#include <math.h>
using namespace std;

bool is_prime(int n)
{
    bool result = true;
    for (int i = 2; i < sqrt(n) + 1; i++)
    {
        if (n % i == 0)
        {
            result = false;
            break;
        }
    }
    return result;
}

int countprime(int n)
{
    int count = 0;
    for (int i = 2; i <= n; i++)
    {
        if (is_prime(i))
        {
            count++;
        }
    }
    return count;
}

int main() {
    int n = 1000000;
    double timecost;
    double start = GetTickCount();
    cout << countprime(n) << endl;
    double end = GetTickCount();
    timecost = end - start;
    cout << "Time: " << timecost << endl;
}
