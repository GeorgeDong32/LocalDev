#include <iostream>
using namespace std;

int main()
{
    int n = 0;
    cin >> n;
    int* num = new int[n];
    int** maxAdress = &num;
    cout << "num adress: " << num << endl;
    for(int i = 0; i < n; i++)
        cin >> num[i];
    for(int i = 0; i < n; i++)
    {
        cout << "before: num[" << i << "] = " << num[i] << "\t&num[" << i << "] = " << &num[i];
        cout << "\t**A = " << **maxAdress << "\t*A = " << *maxAdress << endl;
        if(**maxAdress < num[i])
        {
            *maxAdress = &num[i];
            cout << num << endl;
        }
        cout << "After: num[" << i << "] = " << num[i] << "\t&num[" << i << "] = " << &num[i];
        cout << "\t**A = " << **maxAdress << "\t*A = " << *maxAdress << endl;
    }
    cout << "the max num is " << **maxAdress << "and its adress is " << *maxAdress << endl;
    delete[] num;
    return 0;
}
