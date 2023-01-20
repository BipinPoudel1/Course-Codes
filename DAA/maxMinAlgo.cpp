#include <bits/stdc++.h>
using namespace std;
class sea {
	public:
	int maxm, minm;
	int arr[50];

	void maxMin(int start, int end){
	int max1, min1, mid;
	if(start==end){
		maxm=minm=arr[start];
	}else{
		if(start==end-1){
			if(arr[start]<arr[end]){
				maxm=arr[end];
				minm=arr[start];
			}else{
				maxm=arr[start];
				minm=arr[end];
			}
		}else{
			mid=(start+end)/2;
			maxMin(start, mid);
			max1=maxm;
			min1=minm;
			maxMin(mid+1, end);
			if(maxm<max1){
				maxm=max1;
			}
			if(minm>min1){
				minm=min1;
			}
		}
	}
}
};

int main(){
	int size;
	sea A;
	cout<<"Size of array= ";
	cin>>size;
	cout<<"Elements= ";
	for(int i=1; i<=size; i++){
		cin>>A.arr[i];
	}
	A.maxm=A.arr[0];
	A.minm=A.arr[0];
	A.maxMin(1, size);
	cout<<"Minimum element in the array= "<<A.minm<<endl;
	cout<<"Maximum element in the array= "<<A.maxm<<endl;
	return 0;
}