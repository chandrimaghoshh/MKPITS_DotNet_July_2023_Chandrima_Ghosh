#include<stdio.h>
void main()
{
	int num; 
	int i;
	int result=0;
	printf("Enter table: ");
	scanf("%d",&num);
	for(i=1;i<=10;i++)
	{
		result=num*i;
		printf("%d x %d= %d\n", num, i, result);
	}
}

//ALGORITHM
//1. start
//2. declare num, i, result=0
//3. check i=1;i<=10;i++ then,
//4. print "num, i, result"
//5.stop
