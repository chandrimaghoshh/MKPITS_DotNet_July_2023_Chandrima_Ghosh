#include<stdio.h>
int addition(int n1, int n2)
{
	int result=n1+n2;
	return result;
}
void main()
{
	char ch='y';
	do
	{
		int n1,n2,result;
	  	printf("Enter 2 numbers: ");
		scanf("%d%d",&n1,&n2);
		result=addition(n1,n2);
		printf("result=%d",result);
		printf("\ndo you want to continue, press y: ");
		fflush(stdin);
		scanf("%c",ch);
	}
	while(ch=='y');	
}
