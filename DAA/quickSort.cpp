// Selecting last element as pivot
#include <bits/stdc++.h>
using namespace std;

class sea
{
public:
	void swap(int *a, int *b){
		int temp = *a;
		*a = *b;
		*b = temp;
	}

	int partition(int array[], int low, int high){
		int pivot = array[high]; 
		int i = (low - 1);	 

		for (int j = low; j <= high - 1; j++){
			if (array[j] < pivot)
			{
				i++; 
				swap(&array[i], &array[j]);
			}
		}
		swap(&array[i + 1], &array[high]);
		return (i + 1);
	}

	void QuickSort(int array[], int low, int high){
		if (low < high)
		{
			int pi = partition(array, low, high);
			QuickSort(array, low, pi - 1);
			QuickSort(array, pi + 1, high);
		}
	}

	void Array(int arr[], int size){
		int i;
		for (i = 0; i < size; i++)
			cout << arr[i] << " ";
		cout << endl;
	}
};


int main()
{
	sea A;
	int list[] = {6, 3, 9, 5, 2, 8, 7};
	int n = sizeof(list) / sizeof(list[0]);
	A.QuickSort(list, 0, n - 1);
	cout << "Sorted array: \n";
	A.Array(list, n);
	return 0;
}
