#include<stdio.h>
void main()
{
	int i,arr[5];
	for(i=0;i<5;i++)
	{
		printf("Enter number: ");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		if(arr[i]%2==0)
		{
			printf("Even num : %d\n",arr[i]);
		}
		else
		{
			printf("Odd num : %d\n",arr[i]);
		}
	}
}

//ALGORITHM
//1. start
//2. declare i,arr[5]
//3. Accept "arr[i]"
//4. for i=0;i<5;i++ then,
//5. check if arr[i]%2==0 
//6. print "arr[i]
//7. stop
