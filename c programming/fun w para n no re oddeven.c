//Function with parameters and without returning value

#include<stdio.h>
void oddeven(int num, int rem)
{
	if(num%2==0)
	{
		printf("it is even number");
	}
	else
	{
		printf("it is odd number");
	}
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
//4. declare num,rem=0
//5. Accept num
//6. check if num%2==0 then,
//    6.1) print "it is even number"
//else print "it is odd number
//7. go to main function
//8. call oddeven
//9. stop
