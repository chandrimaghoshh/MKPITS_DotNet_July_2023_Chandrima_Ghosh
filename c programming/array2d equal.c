#include<stdio.h>
void main()
{
	int arr1[2][2];
	int arr2[2][2];
	int row,col,i;
	printf("Enter first matrix: ");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr1[row][col]);
		}
	}
	printf("Enter second matrix: ");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr2[row][col]);
		}
	}
	i=1;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			if(arr1[row][col]!=arr2[row][col])
			i=0;
			break;
		}
	}
	if(i==1)
	{
		printf("\nMatrices are equal");
	}
	else
	{
		printf("\nMatrices are not equal");
	}
}
//ALGORITHM
//1.start
//2.declare arr1[2][2],arr2[2][2],row,col,i
//3.print first matrix
//4.for row=0;row<2;row++
//5.for col=0;col<2;col++
//6.Accept arr1[row][col]
//7.print second matrix 
//8.for row=0;row<2;row++
//9.for col=0;col<2;col++
//10.Accept arr2[row][col]
//10.i=1 then,
//11.for row=0;row<2;row++
//12.for col=0;col<2;col++
//13.if arr1[row][col]!=arr2[row][col]
//   13.1)i=0
//   13.2)break
//15.if i=1
//16. print "matrices are equal
//17.else matrices are not equal
//18.stop

