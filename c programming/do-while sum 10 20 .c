#include<stdio.h>
void main()
{
	int counter = 10;
	int sum = 0;
	do
	{
		sum = sum + counter;
		counter=counter+1;
	}
	while(counter<=20);
    {
				
	}
	printf("sum is %d\n",sum);
}


//ALGORITHM
//1. start
//2. declare counter=10, sum=0
//3. sum = sum + counter
//    counter = counter + 1 then
//4. if counter is less equal to 20 then
//4. print "sum is"
//5. stop 
