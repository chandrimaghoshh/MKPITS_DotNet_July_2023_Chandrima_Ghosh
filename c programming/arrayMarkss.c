#include<stdio.h>
void main()
{
	int i;
	int sum=0;
	int marks[3];
	marks[0]=99;
	marks[1]=88;
	marks[2]=77;
	for(i=0;i<3;i++)
	{
		printf("\nMarks = %d ",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nTotal marks = %d",sum);
}

//ALGORITHM
//1. start
//2. declare i, sum=0, marks[3]
//3. initialization marks[0]=99, marks[1]=88,marks[2]=77
//4. for i=0;i<5;i++
//   4.1) print "marks[i]
//   4.2) sum=sum+marks[i]
//5. print "sum"
//6. stop
