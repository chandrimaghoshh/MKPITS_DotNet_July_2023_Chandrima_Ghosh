//Function with parameters and returning value

#include<stdio.h>
void oddeven()
{
	int num,rem=0;
	printf("Enter num: ");
	scanf("%d",&num);
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
	oddeven();
}

//ALGORITHM
//1. start
//2. declare num,rem=0
//3. Accept num
//4. check if num%2==0 then,
//    4.1) print "it is even number"
//else print "it is odd number
//5. go to main function
//6. call oddeven
//7. stop
