//
// Created by GeorgeDong on 2022/10/30.
//

#ifndef TEST_SOLUTION_H
#define TEST_SOLUTION_H
#include <vector>
#include <stdlib.h>
using namespace std;

class Solution {
    public:
    int maximalSquare(vector<vector<char>>& matrix)
        {
            int iptr,jptr;
            int ans=0,lng=0,sht=0,row,colmn;
            if(matrix.size()==0 || matrix[0].size()==0) return ans;
            row=matrix.size();
            colmn = matrix[0].size();
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<colmn;j++)
                {
                    iptr = i;
                    jptr = j;
                    while(jptr<colmn && matrix[i][jptr]=='1') ++jptr;
                    lng = jptr-j;
                    while(iptr<row && matrix[iptr][j]=='1') ++iptr;
                    sht = iptr-i;
                    lng = min(lng, sht);
                    ans = max(lng, ans);
                    // j = jptr;
                }
            }
            return ans*ans;
        }
};


#endif //TEST_SOLUTION_H
