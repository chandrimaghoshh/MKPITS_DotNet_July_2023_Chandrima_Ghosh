#include<stdio.h>
void main()
{
	int i;
	for(i=1;i<=10;i++)
	{
		printf("num= %d\n", i);
		if(i%2==0)
		{
		break;	
		}
	}
	printf("\nBye ");
}
