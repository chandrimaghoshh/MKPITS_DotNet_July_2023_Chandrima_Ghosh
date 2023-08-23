#include<iostream>
using namespace std;
int function(int x, int y)
{
	if(y<=0)
	{
		return(1);
	}
	else
	{
		return x*(function(x,y-1));
	}
}
int main()
{
	int res;
	res = function(5,3);
	cout<<"Result = "<<res;
	return 0;
}
