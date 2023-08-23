#include<stdio.h>
void main()
{
	int num, rem, sum=0,i;
	printf("Enter num: ");
	scanf("%d",&num);
	
	for(i=num;num!=0;num=num/10)
	{
		rem=num%10;
		sum=sum + (rem*rem*rem);
	}
	if(sum==i)
	{
	   printf("%d is armstrong number\n", i);
	}
	else
	{
		printf("%d is not armstrong number\n", i); 
	}
}

//ALGORITHN
//1. start
//2. declare num, rem, sum=0, i
//3. Accept num
//4. for i=num;num!=0;num=num/10 then
//    3.1) rem=num%10
//    3.2) sum=sum+(rem*rem*rem)
//5. if sum==i then,
//    5.1) print "%d is armstrong number"
//6. else print "%d is not armstrong number"
//stop
