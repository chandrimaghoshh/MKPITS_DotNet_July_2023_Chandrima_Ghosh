#include<stdio.h>
void main()
{
	int num;
	printf("Enter num ");
	scanf("%d",&num);
	if(num<0)
	{
		printf("num is negative");
	}
	else if(num==0)
	{
		printf("num is equal to zero");
	}
	else
	{
		printf("num is positive");
	}
}

// ALGORITHM
//1. start
//2. if num is less than zero then
//    2.1) print "num is negative"
//3. else if num is equal to 0 then
//    3.1) print "num is equal to zero"
//4. else "num is positive"
//5. stop


