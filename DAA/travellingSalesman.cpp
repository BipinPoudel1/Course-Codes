#include <bits/stdc++.h>
using namespace std;
class sea
{
public:
	int c = 0, cost = 999;
	int graph[4][4] = {{0, 20, 42, 35},
			   {20, 0, 30, 34},
			   {42, 30, 0, 12},
			   {35, 34, 12, 0}};
	void swap(int *x, int *y)
	{
		int temp;
		temp = *x;
		*x = *y;
		*y = temp;
	}
	void copy_array(int *a, int n)
	{
		int i, sum = 0;
		for (i = 0; i <= n; i++)
		{
			sum += graph[a[i % 4]][a[(i + 1) % 4]];
		}
		if (cost > sum)
		{
			cost = sum;
		}
	}
	void permute(int *a, int i, int n)
	{
		int j, k;
		if (i == n)
		{
			copy_array(a, n);
		}
		else
		{
			for (j = i; j <= n; j++)
			{
				swap((a + i), (a + j));
				permute(a, i + 1, n);
				swap((a + i), (a + j));
			}
		}
	}
};
int main()
{
	sea A;
	int i, j;
	int a[] = {0, 1, 2, 3};
	A.permute(a, 0, 3);
	cout<<"\n--------------------------------------------------------"<<endl;
	cout << "Minimum Cost to Travel all cities: " << A.cost << endl;
	cout<<"--------------------------------------------------------\n"<<endl;
	return 0;
}