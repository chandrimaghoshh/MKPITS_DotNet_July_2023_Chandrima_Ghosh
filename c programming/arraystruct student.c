#include<stdio.h>
#include<string.h>
struct student
{
	int rollno;
	char name[20];
};
void main()
{
	struct student stud[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter rollno and name : ");
		scanf("%d",&stud[counter].rollno);
		scanf("%s",&stud[counter].name);
	}
	printf("\nStudent details");
	for(counter=0;counter<5;counter++)
	{
		printf("\nRollno = %d",stud[counter].rollno);
		printf("\nname = %s",stud[counter].name);
	}
}
//ALGORITHM
//1.start
//2.define function struct student
//3.declare rollno,name
//4.go to main function
//5.call function struct student stud[5]
//6.declare counter
//7.for counter=0;counter<5;counter++
//8.Accept rollno,name
//9.print student details
//10.for counter=0;counter<5;counter++
//11.print rollno,name
//12.stop
