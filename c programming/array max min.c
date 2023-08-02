#include<stdio.h>
void main()
{
	int arr[5];
	int i,max,min;
	printf("Enter number: ");
	for(i=0;i<5;i++)
	{
		scanf("%d",&arr[i]);
	}
	max=arr[0];
	for(i=0;i<5;i++)
	{
		if(arr[i]>max)
		{
			max=arr[i];
		}
	}
	min=arr[0];
	for(i=0;i<5;i++)
	{
		if(arr[i]<min)
		{
			min=arr[i];
		}
	}
	printf("Maximum value : %d\n",max);
	printf("Minimum value : %d\n",min);
}

//ALOGORITHM
//1. start
//2. declare arr[5], i, max,min
//3. for i=0;i<5;i++
//4. accept "arr[i]
//5. max=arr[0]
//6. for i=0;i<5;i++
//7. if arr[i]>max then, 
//    7.1) max=arr[i]
//8. min=arr[0]
//9. for i=0;i<5;i++
//10. if arr[i]<min then,
//     10.1) min=arr[i]
//11. print "max, min"
//12. stop
