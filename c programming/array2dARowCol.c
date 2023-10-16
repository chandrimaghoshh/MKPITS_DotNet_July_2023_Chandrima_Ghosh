#include<stdio.h>
void main()
{
	int arr[2][2];
	int row,col;
	int n1,n2;
	printf("Enter num: ");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr[row][col]);
		}
	}
	for(row=0;row<2;row++)
	{
		n1=n2=0;
		for(col=0;col<2;col++)
		{
			n1=n1+arr[row][col];
			n2=n2+arr[col][row];
		}
		printf("\n sum of row= %d",n1);
		printf("\n sum of col= %d",n2);
		
	}
}
//ALGORITHM
//1.start
//2.declare arr[2][2],row,col,n1,n2
//3.print num
//4.for row=0;row<2;row++
//5.for col=0;col<2;col++
//6.Accept arr[row][col]
//7.for row=0;row<2;row++
//8.n1=n2=0
//9.for col=0;col<2;col++
//10.n1=n1+arr[row][col]
//   n2=n2+arr[col][row]
//11.print n1,n2
//12.stop

