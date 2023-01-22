#include <bits/stdc++.h>
using namespace std;
class sea
{
public:
	int knapSack(int v[], int w[], int n, int W)
	{
		if (W < 0)
			return INT_MIN;
		if (n < 0 || W == 0)
			return 0;
		int in = v[n] + knapSack(v, w, n - 1, W - w[n]);
		int ex = knapSack(v, w, n - 1, W);
		return max(in, ex);
	}
};
int main()
{
	sea A;
	int v[] = {1, 2, 3};
	int w[] = {4, 5, 1};
	int W = 4;
	int n = sizeof(v) / sizeof(v[0]);
	cout<<"\n*************************************************"<<endl;
	cout << "Maximum value in Knapsack= " << A.knapSack(v, w, n - 1, W)<<endl;
	cout<<"*************************************************\n"<<endl;
	return 0;
}