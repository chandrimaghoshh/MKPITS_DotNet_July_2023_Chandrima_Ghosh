#include<stdio.h>
void main()
{
	int num, counter = 1, result;
	printf("Enter number: ");
	scanf("%d",&num);
	while(counter<=10)
	{
		result=num*counter;
		counter=counter+1;		
	 	printf("%d\n",result);
	}
	
}

//ALGORITHM
//1. start
//2. declare counter=1, num, result
//3. Accept num
//4. check if counter is less than equal to 1 then
//    4.1) result=num*counter
//    4.2) counter=counter+1 then
//5. print "result"
//6. stop

