#include<stdio.h>
#include<string.h>
struct employee
{
	int sal;
	int id;
	char name[20];
	char desig[20];
	char depart[20];
};
void main()
{
	struct employee emp[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter Salary, Id, Name, Desig, Depart : ");
		scanf("%d%d%s%s%s",&emp[counter].sal,&emp[counter].id,&emp[counter].name,&emp[counter].desig,&emp[counter].depart);
	}
	printf("\nEmployee Details :");
	for(counter=0;counter<5;counter++)
	{
		printf("\nSal =  %d\t",emp[counter].sal);
		printf("Id = %d\t",emp[counter].id);
		printf("Name = %s\t",emp[counter].name);
		printf("Desig = %s\t",emp[counter].desig);
		printf("Dpart = %d\t",emp[counter].depart);
	}
}
//ALGORITHM
//1.start
//2.define function struct employee
//3.declare sal,id,anme,desig,depart
//4.go to main function
//5.call function struct employee emp[5]
//6.declare counter
//7.for counter=0;counter<3;counter++
//8.Accept sal,id,name,desig,depart
//9.print employee details
//10.for counter=0;counter<3;counter++
//11.print sal,id,name,desig,depart
//12.stop
