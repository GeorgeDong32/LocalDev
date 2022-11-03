#include <iostream>
#include "Solution.h"
#include <vector>
using namespace std;

int main()
{
    Solution s = Solution();
    vector<vector<char>> test(6,vector<char>(6));
    char temp = 0;
    for(int i = 0; i < 6; i++)
    {
        for(int j = 0; j < 6; j++)
        {
            cin >> temp;
            test[i].push_back(temp);
        }
    }
    int re = s.maximalSquare(test);
    cout << "Result: " << re << endl;
    return 0;
}
