#include <bits/stdc++.h>
using namespace std;

// structure for holding values
typedef struct Job
{
	int jobNum;
	int deadline;
	int profit;
} Job;

// a custom comparison function for arrenging jobs in decreasing order of profit
bool compare(Job a, Job b)
{
	return (a.profit > b.profit);
}

// main part of code where job sequencing happens
void jobSequencing(Job input[], int num)
{
	sort(input, input + num, compare);

	int result[num];

	bool slot[num];
	// setting all values in slot as false
	memset(slot, 0, sizeof(slot));

	for (int i = 0; i < num; i++)
	{
		for (int j = min(num, input[i].deadline) - 1; j >= 0; j--)
		{
			if (slot[j] == false)
			{
				result[j] = i;
				slot[j] = true;
				break;
			}
		}
	}

	cout << "Job sequenced in order: ";
	for (int i = 0; i < num; i++)
	{
		if (slot[i] == true){
			cout << input[result[i]].jobNum <<  " -> ";
	}
	}
}

int main()
{
	int num;
	cout << "Give the number of jobs! - ";
	cin >> num;
	Job input[num];
	// inputing the values
	cout << "Give corresponding JobID, Deadline, Profit" << endl;
	for (int i = 0; i < num; i++)
	{
		cin >> input[i].jobNum;
		cin >> input[i].deadline;
		cin >> input[i].profit;
	}

	jobSequencing(input, num);
}
