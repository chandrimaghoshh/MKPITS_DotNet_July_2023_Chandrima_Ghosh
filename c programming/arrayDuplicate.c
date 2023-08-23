#include<stdio.h>
void main()
{
	int arr[5];
	int i,count=0;
	int j;
	for(i=0;i<5;i++)
	{
		printf("Enter number: ");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arr[i]==arr[j])
			{
				count++;
				break;
			}
		}
	}
	printf("\nDuplicate elements = %d",count);
}

//ALGORITHM
//1. start
//2. declare arr[5], i,count=0,j
//3. for i=0;i<5;i++
//4. print "arr[i]
//5. for i=0;i<5;i++
//6. for j=0;j<5;j++
//7. if arr[i]==arr[j]
//    7.1) count++
//    7.2) break
//8. print "count"
//9. stop
