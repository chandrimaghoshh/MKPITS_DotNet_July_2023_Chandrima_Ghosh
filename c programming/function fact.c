#include<stdio.h>
void factorial(int fact,int num)
{
	while(num>0)
	{
		fact=fact*num;
		num=num-1;
	}
	printf("factorial of number=%d\n",fact);
    
}
void main()
{
	int fact=1,num;
	printf("Enter num: ");
	scanf("%d",&num);
	factorial(fact,num);
}

//ALGORITHM
//1. start
//2. define function factorial
//3. while num<0 then
//   3.1)fact=fact*num
//   3.2)num=num-1
//4. print "fact"
//5. calling function
//6. declare fact=1, num
//7. factorial(fact,num)
//8. stiop
	
