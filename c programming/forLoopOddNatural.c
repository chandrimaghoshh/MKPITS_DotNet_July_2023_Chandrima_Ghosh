#include<stdio.h>
void main()
{
	int num, i, sum=0;
	printf("Enter num ");
	scanf("%d",&num);
	
	printf("odd no from 1 to %d are:\n", num);
	for(i=1;i<=num;i++)
	{
		if(i%2!=0)
		{
		  printf("%d\n", i);
		  sum = sum+i;
	    }
	}
	printf("sum of all odd natural numbers %d is %d\n", num, sum);
}

//ALGORITHM
//1. start
//2. Declare num,i,sum=0
//3. Accept num
//4. print "num"
//5. for i=1;i<=num;i++ then
//6. if i%2!=0 then,
//    6.1) print "i"
//    6.2) sum=sum+i
//7. print "sum of all odd num"
//8. stop 
