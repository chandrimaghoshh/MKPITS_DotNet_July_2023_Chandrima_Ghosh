#include<stdio.h>
void main()
{
	int num, i=1, square, sum=0; 
	printf("Enter num: ");
	scanf("%d",&num);
	
	printf("square no from 1 to %d are:\n", num);
	for(i=1;i<=num;i++)
	{
		square=i*i;
		printf("%d\n", square);
		sum=sum+square;
	}
	printf("sum of all square natural numbers btween 1 to %d is: %d\n", num, sum);
}


//ALGORITHM
//1. start
//2. Declare num, i=1, square, sum=0
//3. Accept num
//4. print "square no from 1 to %d"
//5. for i=1;i<=num;i++ then
//6. square=i*i
//    6.1) print "square"
//    6.2) sum=sum+square;
//7. print "sum of all square natural num"
//8. stop 
