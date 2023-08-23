#include<stdio.h>
#include<string.h>
struct student
{
	int rollno;
	char name[20];
	struct date
	{
		int date;
		int month;
		int year;
	}
	birthdate,addate;
};
void main()
{
	struct student stud[2];
	int counter,result;
	for(counter=0;counter<2;counter++)
	{
		printf("Enter Rollno., Name : ");
		scanf("%d%s",&stud[counter].rollno,&stud[counter].name);
		printf("Enter Birthday : ");
		scanf("%d-%d-%d",&stud[counter].birthdate.date,&stud[counter].birthdate.month,&stud[counter].birthdate.year);
		printf("Addmission Date : ");
		scanf("%d-%d-%d",&stud[counter].addate.date,&stud[counter].addate.month,&stud[counter].addate.year);
	}
	for(counter=0;counter<2;counter++)
	{
		result=stud[counter].addate.year - stud[counter].birthdate.year;
		printf("\nAge of student at the time of addmission : ");
		printf("\t%d years",result);
	}
}
//ALGORITHM
//1.start
//2.define function struct student then,
//3.declare rollno,name,yera
//4.define struct date
//5.declare date,month,year
//   5.1)birthdate,addate
//6.go to main function
//7.call function struct stud
//8.declare int counter,result
//9.for counter=0,counter<5;counter++ then,
//10.Accept rollno,name,birthday=date,month,year;admission=date,month,year
//11.for counter=0,counter<5;counter++ then,
//12.reuslt =stud[counter].addate.year - stud[counter].birthdate.year;
//13.print result
//14.stop			  	 
