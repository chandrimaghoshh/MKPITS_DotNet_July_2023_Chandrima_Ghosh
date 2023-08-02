#include<stdio.h>
void main()
{
	int i;
	int sum=0;
	int marks[5];
	for(i=0;i<5;i++)
	{
		printf("Enter 5 subject marks:");
		scanf("%d",&marks[i]);
	}
	for(i=0;i<5;i++)
	{
		printf("\nMarks=%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nTotal marks = %d",sum);
}

//ALGORITHM
//1. start
//2. declare i, sum=0, marks[5]
//3. for i=0;i<5;i++
//   3.1) print "marks[i]
//4. for i=0;i<5;i++
//5. print marks[i]
//6. sum=sum+marks[i]
//7. print "sum"
//8. stop
