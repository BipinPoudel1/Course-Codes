#include <bits/stdc++.h>
using namespace std;
class sea{
	public:
	int size, elements[50], key, mid;

	void binarySearch(int elements[], int key, int mid){
		int start=0, end=size, flag=0;
		while(start<=end){
		mid=(start+end)/2;
			if(elements[mid]==key){
				cout<<"Element found at index ["<<mid<<"]";
				flag=1;
				break;
			}else if(key>elements[mid]){
				start=mid+1;
			}else{
				end=mid-1;
			}
		}
		if(flag==0){
			cout<<"Element Not Found!";
		}
	}

};

int main()
{
	sea A;
	cout<<"Enter the size of an array~ ";
	cin>>A.size;
	cout<<"Enter the elements in ascending order~ ";
	for(int i=0; i<A.size; i++){
		cin>>A.elements[i];
	}
	cout<<"Enter the key element to search~ ";
	cin>>A.key;
	A.binarySearch(A.elements, A.key, A.mid);
	return 0;
}