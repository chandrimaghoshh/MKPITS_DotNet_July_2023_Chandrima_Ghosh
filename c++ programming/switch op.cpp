#include<iostream>
using namespace std;
int main()
{
	int n1,n2,result=0;
	char op;
	cout<<"Enter 2 numbers : ";
	cin>>n1>>n2;
	cout<<"Enter op(+,-,*,/): ";
	cin>>op;
	switch(op)
	{
	
		case '+':
		result=n1+n2;
		break;
		case '-':
		result=n1-n2;
		break;
		case '*':
		result=n1*n2;
		break;
		case '/':
		result=n1/n2;
		break; 
	}
	cout<<"result = "<<result;
	return 0;
}
