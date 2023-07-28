#include<stdio.h>
void table(int num, int i)
{
	for(i=1;i<=10;i++)		
	{
	printf("%d*%d=%d\n", num, i, num*1);
    }
}
void main()
{
	int num, i=1;
	printf("Enter number: ");
	scanf("%d",&num);
	table(num,i);
}

//ALGORITHM
//1. start
//2. define the function table
//3. for(i=1;i<=10;i++)
//   3.1) print "%d*%d=%d
//4. goto main function
//5. declare num, i=1
//6. print calling function
//7. table(num,i)
//8. stop
