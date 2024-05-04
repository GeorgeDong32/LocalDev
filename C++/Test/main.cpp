#include <iostream>
using namespace std;

double GetPower(double x, int y)
{
    if(y < 0)
        return (1 / GetPower(x, -y));
    else if(y == 0)
        return 1;
    else
        return x * GetPower(x, y -1);
}

int main() {
    double a = 2.0;
    int b = -1;
    cout << GetPower(a, b) << endl;
    return 0;
}