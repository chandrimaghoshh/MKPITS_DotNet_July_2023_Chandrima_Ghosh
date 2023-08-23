#include<stdio.h>
void main()
{
	int counter=2; 
	int num;
	int rem=0;
	for(num=3;num<=20;num++)
	{
		counter=2;
		while(counter<num)
		{
		  rem=num%counter;
		  if(rem==0)
		  {
		  break;
		  }
		counter++;
	    }
	if(num==counter)
	{
		printf("%d= is a prime num\n", num);
	}
	}
}

//ALGORITHM
//1. start
//2. Declare counter=2, num,rem
//5. for i=1;i<=num;i++ then
//    5.1) counter=2
//6. while counter<num then,
//    6.1) rem=num%counter
//7. if rem==0 then,
//    7.1)break
//    7.2)counter++
//8. if num===counter then
//    8.1) print "it is a prime number"
//9. stop 
