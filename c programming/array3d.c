#include<stdio.h>
void main()
{
	int arr[3][3];
	int row,col;
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)	
		{
			printf("Enter number: ");
			scanf("%d",&arr[row][col]);
		}
	}
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			printf("\narr[%d][%d]=%d",row,col,arr[row][col]);
		}
	}
}

//ALGORITHM
//1.start
//2.declare arr[3][3],row,col
//3.for row=0;row<3;row++
//4.for col=0;col<3;col++ then,
//5.Accept arr[row][col]
//6.for row=0;row<3;row++
//7. for col=0;col<3;col++ then,
//8.print row,col,arr[row][col]
//9.stop
