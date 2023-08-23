#include<iostream>
using namespace std;
int factorial(int n);
int main()
{
	int num,fact;
	cout<<"Enter number : ";
	cin>>num;
	fact = factorial(num);
	cout<<"Factorial of num = "<<fact;
	return 0;
}
int factorial(int n)
{
	if(n==0)
	{
		return(1);
	}
	else
	{
		return(n*factorial(n-1));	
	}
}


