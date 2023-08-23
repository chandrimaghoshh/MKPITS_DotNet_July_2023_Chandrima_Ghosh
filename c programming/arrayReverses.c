#include<stdio.h>
void main()
{
	int n,i,num[100];
	printf("Enter n numbers: ");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		printf("Enter numbers: ");
		scanf("%d",&num[i]);
	}
	for(i=n-1;i>=0;i--)
	{
		printf("\nReverse numbers are = %d",num[i]);
	}
}

//ALGORITHM
//1. start
//2. declare n,i,num[100]
//3. Accept n
//4. for i=0;i<5;i++
//5. print num[i]
//6. for i=n-1;i>0;i--
//7. print "num[i]
//8. stop


