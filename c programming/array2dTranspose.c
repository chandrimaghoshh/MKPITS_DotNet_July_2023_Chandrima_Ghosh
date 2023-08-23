#include<stdio.h>
void main()
{
	int arr1[2][2];
	int arr2[2][2];
	int row,col;
	printf("Enter num: ");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr1[row][col]);
		}	
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arr2[row][col]=arr1[col][row];
		}
	}
	printf("Transpose matrices:\n");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("%d\t",arr2[row][col]);
		}
		printf("\n");
	}
}
//ALGORITHM
//1.start
//2.declare arr1[2][2],arr2[2][2],row,col,n1,n2
//3.print num
//4.for row=0;row<2;row++
//5.for col=0;col<2;col++
//6.Accept arr1[row][col]
//7.for row=0;row<2;row++
//8.for col=0;col<2;col++
//9.arr2[row][col]=arr1[row][col]
//10.print "Transpose matrices"
//11.for row=0;row<2;row++
//12.for col=0;col<2;col++
//13.print arr2[row][col]
//14.print "\n"
//15.stop

