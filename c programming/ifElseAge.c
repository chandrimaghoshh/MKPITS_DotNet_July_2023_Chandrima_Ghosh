#include<stdio.h>
void main()
{
	int a, b;
	printf("Enter age");
	scanf("%d",&a);
	printf("Enter age");
	scanf("%d",&b);
	if(a> 75)
	{
		printf("%d is old", a);
	}
	else
	{
		printf("%d is adult", b);
	}
}
