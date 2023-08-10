#include<iostream>
using namespace std;
int main()
{
	int row,col,space,k;
	space=row+3-1;
	for(row=1;row<3;row++)
	{
		for(k=space;k>=1;k--)
		{
			cout<<" ";
		}
	}
			for(col=1;col<row;col++)
			{
			  cout<<"* ";
			}
		 	space--;
			cout<<endl;
			
}
	

