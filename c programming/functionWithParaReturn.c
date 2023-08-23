#include<stdio.h>
int area(int side)
{
	int result=side*side;
	return result;
}
void main()
{
	char ch='y';
	do
	{
		int side,result=0;
		printf("Enter side: ");
		scanf("%d",&side);
		result=area(side);
		printf("Area of square=%d",result);
		printf("\ndo you want to continue,press y: ");
		fflush(stdin);
		scanf("%c",ch);
	}
	while(ch=='y');
}
