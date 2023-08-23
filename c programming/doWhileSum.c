#include<stdio.h>
void main()
{
	int counter = 1;
	int sum = 0;
	do
	{
		sum = sum + counter;
		counter = counter + 1;
	}
	while(counter<=5);
	{
		counter=counter-1;
		printf("sum is %d",sum);
	}
	
}
