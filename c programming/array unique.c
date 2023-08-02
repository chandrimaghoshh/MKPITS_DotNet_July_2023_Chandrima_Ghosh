#include<stdio.h>
void main()
{
	int i,j,arr[5],count=0;
	for(i=0;i<5;i++)
	{
		printf("Enter num: ");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		count=0;
		for(j=0;j<5;j++)
		{
			if(i!=j)
			{
				if(arr[i]==arr[j])
				{
					count++;
					break;
				}
			}
		}
		if(count==0)
		{
			printf("\nUnique Elements = %d",arr[i]);
		}
	}
}
//ALGORITHM
//1. start
//2. declare i,j,arr[5],count=0
//3. for i=0;i<5;i++ then, print "arr[i]
//4. for i=0;i<5;i++ then, count=0
//5.   for j=0;j<5;j++ then,
//6. check if i!=j then,
//7.  if arr[i]==arr[j] then,
//    7.1) count++
//    7.2) break
//8. if count==0 then,
//9. print "arr[i]
//10. stop
