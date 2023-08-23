#include<stdio.h>
#include<string.h>
struct workers
{
	char name[20];
	int wage;
	int working_days;
	int total_sal;
};
void main()
{
	struct workers work[2];
	int counter,wage,working_days,total_sal;
	for(counter=0;counter<2;counter++)
	{
		printf("Enter Name, Wages, Working day : ");
		scanf("%s%d%d",&work[counter].name,&work[counter].wage,&work[counter].working_days);
	}
	printf("\nworkers details: ");
	for(counter=0;counter<2;counter++)
	{
		work[counter].total_sal = work[counter].wage * work[counter].working_days;
	}
	for(counter=0;counter<2;counter++)
	{
		printf("\nName =  %s\t",work[counter].name);
		printf("Wages = %d\t",work[counter].wage);
		printf("Working days = %d\t",work[counter].working_days);
		printf("total_sal = %d\t",work[counter].total_sal);
	}
}
//ALGORITHM
//1.start
//2.define function struct workers
//3.declare name,wage,working_days,total_sal
//4.go to main function
//5.call function struct workers work[2]
//6.declare counter,wages,working_days,total_sal
//7.for counter=0;counter<2;counter++ then,
//8.print workers details
//9.for counter=0;counter<2;counter++ then,
//10.work[counter].total_sal = work[counter].wage * work[counter].working_days
//11.for counter=0;counter<2;counter++ then,
//12.print name,wages,working_days,total_sal
//13.stop
