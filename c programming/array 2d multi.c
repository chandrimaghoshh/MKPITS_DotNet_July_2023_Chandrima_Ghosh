#include<stdio.h>
void main()
{
	int arr1[2][2]={{1,2},{3,4}};
	int arr2[2][2]={{5,6},{7,8}};
	int arr3[2][2];
	int row,col;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arr3[row][col]=arr2[row][col]*arr1[row][col];
		}
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("Multiplication = %d ",arr3[row][col]);
		}
		printf("\n");
	}
}

//ALGORITHM
//1.start
//2.declare arr1[2][2]={{1,2}.{3,4}}->initialization
//       arr2[2][2]={{5,6},{7,8}}->intialization
//       arr3[2][2],row,col
//3.for row=0;row<2;row++
//4.for col=0;col<2;col++
//5.arr3[row][col]=arr2[row][col]*arr1[row][col]
//6.for row=0;row<2;row++
//7.for col=0;col<2;col++ then,
//8.print arr3[row][col]
//9.print \n
//10.stop
