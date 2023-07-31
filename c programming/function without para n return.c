#include<stdio.h>
int addition()
{
	int n1,n2;
	printf("Enter 2 numbers: ");
	scanf("%d%d",&n1,&n2);
	int result=n1+n2;
	return result;
}
void main()
{
	char ch='y';
	do
	{
		int result;
		result=addition();
		printf("Result=%d\n",result);
		printf("\ndo you want to continue,press y: ");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}
