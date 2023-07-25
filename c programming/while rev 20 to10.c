#include<stdio.h>
void main()
{
	int counter = 10;
	int sum = 0;
	while(counter>=20)
	{
		sum = sum + counter;
		counter=counter+1;		
	}
	printf("%d\n",sum);
	
}

//ALGORITHM
//1. start
//2. declare counter=10, sum=0
//3. check counter is greater than or equal to zero then,
// 		4.1) sum = sum+counter
//      4.2) counter = counter+1
//5. print "sum"
//6. stop
