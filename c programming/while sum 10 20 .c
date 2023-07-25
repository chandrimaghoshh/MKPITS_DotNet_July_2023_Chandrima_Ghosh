#include<stdio.h>
void main()
{
	int counter = 10;
	int sum = 0;
	while(counter<=20)
    {
		sum = sum + counter;
		counter=counter+1;
			
	}
	printf("sum is %d\n",sum);
}


//ALGORITHM
//1. start
//2. declare counter=10, sum=0
//3. if counter is less equal to 20 then
//    3.1) sum = sum + counter
//    3.2) counter = counter + 1 then
//4. print "sum is"
//5. stop 
