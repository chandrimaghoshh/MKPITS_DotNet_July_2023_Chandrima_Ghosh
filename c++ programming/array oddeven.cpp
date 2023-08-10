#include<iostream>
using namespace std;
int main()
{
	int i,arr[5];
	for(i=0;i<5;i++)
	{
		cout<<"Enter number : ";
		cin>>arr[i];
	}
	for(i=0;i<5;i++)
	{
		if(arr[i]%2==0)
		{
			cout<<"Even num is : "<<arr[i]<<endl;
		}
		else
		{
			cout<<"Odd num is : "<<arr[i]<<endl;
		}
	}
	return 0;
}
