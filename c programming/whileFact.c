#include<stdio.h>
void main()
{
	int fact =1, num;
	printf("Enter num: ");
	scanf("%d",&num);
	while(num>0)
	{
		fact = fact * num;
		num = num - 1;	   
	}
	printf("factorial=%d",fact);
}

