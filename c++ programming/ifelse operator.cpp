#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0;
	char op;
	cout<<"Enter 2 numbers : ";
	cin>>n1>>n2;
	cout<<"Enter (+,-,*,/) : ";
	cin>>op;
	if(op=='+')
	{
		sum=n1+n2;
	}
	else if(op=='-')
	{
		sum=n1-n2;
	}
	else if(op=='*')
	{
		sum=n1*n2;
	}
	else if(op=='/')
	{
		sum=n1/n2;
	}
	cout<<"Sum = "<<sum;
	return 0;
}
