//Function with parameters and returning value

#include<stdio.h>
int oddeven(int num, int rem)
{
	if(num%2==0)
	{
		printf("it is even number");
	}
	else
	{
		printf("it is odd number");
	}
	return 0;
}
void main()
{
	int num,rem=0;
	printf("Enter num: ");
	scanf("%d",&num);
	oddeven(num,rem);
}
//ALGORITHM
//1. start
//3. define function oddeven
//4. check if num%2==0 then,
//    6.1) print "it is even number"
//else print "it is odd number"
//5. go to main function
//6. int num,rem=0
//7. call oddeven
//8. stop
