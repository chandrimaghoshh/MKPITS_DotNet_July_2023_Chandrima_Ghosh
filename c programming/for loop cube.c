#include<stdio.h>
void main()
{
	int i; 
	int num;
	int cube;
	printf("Enter num: ");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		cube=i*i*i;
		printf("\n%d is cube of %d",cube,i);
	}
}

//ALGORITHM
//1. start
//2. Declare i, num, cube
//3. Accept num
//4. for i=1;i<=num;i++ then,
//    4.1) cube = i*i
//    4.2) print "cube"
//5. stop 
