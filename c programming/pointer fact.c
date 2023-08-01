#include<stdio.h>
void factorial(int num, int *fact)
{
	while(num>0)
	{
	  *fact=*fact*num;
	 num=num-1;
	}
	
}
void main()
{
	int num, fact=1;
	printf("Enter number: ");
	scanf("%d",&num);
	factorial(num,&fact);
	printf("factorial is = %d",fact);
}

//ALGORITHM
//1. start
//2. define function factorial
//3. declare  num,*fact=1
//4. check num>0 then,
//5. *fact=*fact*num
//6. num=num-1
//7. go to main function
//8. call factorial(num,&fact)
//9. print "fact"
//10. stop
