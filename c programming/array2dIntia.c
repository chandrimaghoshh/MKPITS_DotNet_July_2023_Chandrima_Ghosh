// Iniatialization of 2d Array
#include<stdio.h>
void main()
{
	int arr[2][2]={{1,2},{3,4}};
	int row,col;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("\narr[%d][%d]=%d",row,col,arr[row][col]);
		}
	}
}

//ALGORITHM
//1.start
//2.declare arr[2][2]={{1,2},{3,4}},row,col
//3.for row=0;row<2;row++
//4.for col=0;col<2;col++ then,
//5.print row,col,arr[row][col]
//6.stop
