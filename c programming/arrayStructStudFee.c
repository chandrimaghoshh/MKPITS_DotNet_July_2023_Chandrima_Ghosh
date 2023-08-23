#include<stdio.h>
#include<string.h>
struct student
{
	int fees;
	char name[20];
};
void main()
{
	struct  student stud[3];
	int counter,per_day,per_hours,total_month;
	int month,hours;
	for(counter=0;counter<3;counter++)
	{
		printf("Enter Name and fees : ");
		scanf("%s%d",&stud[counter].name,&stud[counter].fees);
	}
	for(counter=0;counter<3;counter++)
	{
		month=20;
		hours=8;
		total_month=month*5;
		per_day=stud[counter].fees/total_month;
		per_hours=per_day/8;
		printf("Per day=%d\t",per_day);
		printf("Per hours=%d\t",per_hours);
		
	}
}
//ALGORITHM
//1.start
//2.define function struct student
//3.declare fees,name
//4.go to main function
//5.call function struct student stud[3]
//6.declare counter,per_day,per_hours,total_month,month,hour
//7.for counter=0;counter<3;counter++
//8.month=20,hour=8
//9.total_month=month*5
//10.per_hours=per_day/8
//11.print per_day, per_hour
//12.stop
