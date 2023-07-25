#include<stdio.h>
void main()
{
	int fact =1, num;
	printf("Enter num: ");
	scanf("%d",&num);
	do
	{
		fact = fact * num;
		num = num - 1;		
	}
	while(num>0);
	{
		printf("factorial=%d",fact);		   
	}
	
}


//ALGORITHM
//1. start
//2. declare fact=1, num
//3. print "enter num" then
//   3.1) fact = fact*num
//	 3.2) num = num-1
//4. now check num is less than zero then,
//5. print "fact"
//6. stop

