#include<stdio.h>
void main()
{
	int i,arr1[5],arr2[5];
	for(i=0;i<5;i++)
	{
		printf("Enter numbers: ");
		scanf("%d",&arr1[i]);
	}
	for(i=0;i<5;i++)
	{
		arr2[i]=arr1[i];
	}
	printf("\nElements of arr1: ");
	for(i=0;i<5;i++)
	{
		printf("\n%d",arr1[i]);
	}
	printf("\nElements of arr2 :");
	for(i=0;i<5;i++)
	{
		printf("\n%d",arr2[i]);
	}
}

//ALGORITHM
//1. declare i,arr[5],arr[5]
//2. for i=0;i<5;i++
//3. Accept  arr1[i]
//4. for i=0;i<5;i++
//    4.1) arr2[i]=arr1[i]
//5. print elements of arr1
//6. for i=0;i<5;i++
//    6.1) print arr1[i]
//7. print  elements of arr2
//8. for i=0;i<5;i++
//    8.1) print arr2[i]
//9. stop
