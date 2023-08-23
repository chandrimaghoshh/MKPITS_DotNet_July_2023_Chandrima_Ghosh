#include<stdio.h>
void main()
{
	int i;
	int sum=0;
	int marks[3]={90,80,70};
	for(i=0;i<3;i++)
	{
		printf("\nMarks = %d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nTotal marks = %d",sum);
}

//ALGORITHM
//1. start
//2. declare i,sum=0, marks[3]={90,80,70}
//3. for i=0;i<5;i++
//4. print "marks[i]
//5. sum=sum+marks[i]
//6. print "sum"
//7. stop
