#include <iostream>
#include <string>
#include <vector>
using namespace std;

struct Node {
    char c;
    int w;
    int l;
    int r;
};
vector<Node> tree;
string sa, sb;

int build(int al, int ar, int bl, int br) {
    int index = tree.size();
    int bpos = bl;
    while(sb[bpos] != sa[al]) bpos++;
    int llen=bpos-bl, rlen=br-bpos;
    Node n;
    n.c = sa[al];
    n.w = llen == 0 && rlen == 0 ? 1 : 0;
    tree.push_back(n);
    if(llen != 0) {
        tree[index].l = build(al+1, al+llen, bl, bl+llen-1);
        tree[index].w += tree[tree[index].l].w;
    } else tree[index].l = 0;
    if(rlen != 0) {
        tree[index].r = build(al+llen+1, ar, bl+llen+1, br);
        tree[index].w += tree[tree[index].r].w;
    } else tree[index].r = 0;
    return index;
}

void print(int n) {
    for(int i = 0 ; i < tree[n].w ; i++) cout << tree[n].c;
    cout << endl;
    if(tree[n].l != 0) print(tree[n].l);
    if(tree[n].r != 0) print(tree[n].r);
}

int main() {
    cin >> sa >> sb;
    build(0, sa.size()-1, 0, sb.size()-1);
    print(0);
    return 0;
}