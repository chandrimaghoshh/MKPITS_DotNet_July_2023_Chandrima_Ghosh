#include<stdio.h>
void main()
{
	int counter = 2, num =20, rem=0;
	printf("Enter number: ");
	scanf("%d",&num);
	while(counter<20)
	{
		rem = num%counter;
	if(rem == 0)
	{
		printf("it is not a prime number");
	    break;

	counter = counter+1;	
	if(num == counter)
	{
		printf("it is  prime number");
	}
    }
}

//ALGORITHM
//1. start
//2. declare counter = 2, num, rem
//3. Accept num
//4. check counter<num then
//    4.1) rem = num%counter
//5. if rem==0 then
//    5.1) print "it is not a prime number"
//    5.2) counter = counter +1, then
//6. if num==counter then
//    6.1) print "it is prime number"
//7.stop 
