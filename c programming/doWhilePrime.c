#include<stdio.h>
void main()
{
	int counter = 2, num =20, rem=0;
	printf("Enter number: ");
	scanf("%d",&num);
	do
	{
		rem = num%counter;
	if(rem == 0)
	{
		printf("it is not a prime number");
	    break;

	counter = counter+1;
    }
	if(num == counter)
	{
	printf("it is  prime number");		
	}
	
    }	  
	while(counter<20);
	{
		
	}
}

//ALGORITHM
//1. start
//2. declare counter = 2, num, rem
//3. Accept num
//4. rem = num%counter then,
//5. if rem==0 then
//    5.1) print "it is not a prime number"
//    5.2) counter = counter +1, then
//6. check counter is less than 20 then,
//    6.1) if num==counter
//    6.2) print "it is prime number"
//7.stop 
