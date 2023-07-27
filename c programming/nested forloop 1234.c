#include<stdio.h>
void main()
{
	int row, col, k=1;
	
	for(row=1;row<=3;row++)
	{
		for(col=1;col<=row;col++)
		{
			printf("%d ",k++);
		}
		printf("\n");
	}
}

//ALGORITHM
//1. start
//2. declare row,col,k=1
//3. for row=1;row<=3;row++ then
//4. for col=1;col<=row;col++ then,
//    4.1) print "k++"
//5. print "\n"
//6. stop
