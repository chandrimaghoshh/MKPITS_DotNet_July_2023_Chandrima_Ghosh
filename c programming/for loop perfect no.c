#include<stdio.h>
void main()
{
	int num, i, sum=0;
	printf("Enter num ");
	scanf("%d",&num);
	
	printf("excluding of %d are :\n", num);
	for(i=1;i<num;i++)
	{
		if(num%i==0)
		{
		  printf("%d\n", i);
		  sum = sum+i;
	    }
	}
	if(sum==num)
	   printf("%d is perfect number\n", num);
	else
		printf("%d is not perfect number\n", num); 

}


//ALGORITHM
//1. start
//2. Declare num,i,sum=0
//3. Accept num
//4. print "excluding of %d are"
//5. for i=1;i<num;i++ then
//6. if num%i==0 then,
//    6.1) print "i"
//    6.2) sum=sum+i
//7.if sum==num then,
//   7.1) print "it is perfect number"
//8. else print "it is not perfect number"
//9. stop 
