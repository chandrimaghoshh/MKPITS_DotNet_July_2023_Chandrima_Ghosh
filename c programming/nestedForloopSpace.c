#include<stdio.h>
void main()
{
	int row, col, space, k;
	space=row+3-1;
	for(row=1;row<=3;row++)
	{
		for(k=space;k>=1;k--)
		{
			printf("  ");
		}
		for(col=1;col<=row;col++)
		{
			printf("%d  ",col);
		}
		space--;
		printf("\n");	
	}
	
}

//ALGORITHM
//1. start
//2. declare row,col,space,k
//3. space=row+3-1
//4. for row=1;row<=3;row++
//5. for k=space;k>=1;k-- then,
//    5.1)print ("   ")
//6. for col=1;col<=row;col=++
//    6.1) print "col"
//7. space--
//8. print "\n"
//9.stop
