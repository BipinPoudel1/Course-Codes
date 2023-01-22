#include <bits/stdc++.h>
using namespace std;

struct MinHeapNode
{
	char d;
	unsigned frequency;
	MinHeapNode *lChild, *rChild;

	MinHeapNode(char d, unsigned frequency)

	{

		lChild = rChild = NULL;
		this->d = d;
		this->frequency = frequency;
	}
};

// function to compare
struct compare
{
	bool operator()(MinHeapNode *l, MinHeapNode *r)
	{
		return (l->frequency > r->frequency);
	}
};

class sea
{
public:
	void printCodes(struct MinHeapNode *root, string str)
	{
		if (!root)
			return;

		if (root->d != '$')
			cout << root->d << " _ " << str << "\n";

		printCodes(root->lChild, str + "0");
		printCodes(root->rChild, str + "1");
	}

	void HuffmanCodes(char d[], int frequency[], int size)
	{
		struct MinHeapNode *lChild, *rChild, *top;

		priority_queue<MinHeapNode *, vector<MinHeapNode *>, compare> minHeap;

		for (int i = 0; i < size; ++i)
			minHeap.push(new MinHeapNode(d[i], frequency[i]));

		while (minHeap.size() != 1)
		{
			lChild = minHeap.top();
			minHeap.pop();

			rChild = minHeap.top();
			minHeap.pop();

			top = new MinHeapNode('$', lChild->frequency + rChild->frequency);

			top->lChild = lChild;
			top->rChild = rChild;

			minHeap.push(top);
		}
		printCodes(minHeap.top(), "");
		cout<<"!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"<<endl;
	}
};

int main()
{
	sea A;
	char arr[] = {'a', 'b', 'c', 'd', 'e', 'f'};
	int frequency[] = {5, 9, 12, 13, 16, 45};

	int size = sizeof(arr) / sizeof(arr[0]);
	cout<<"!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"<<endl;
	cout<<"Huffman Code assigned to each character is as follows_ "<<endl;
	A.HuffmanCodes(arr, frequency, size);

	return 0;
}