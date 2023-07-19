#include<stdio.h>
void main()
{
	char name[20]; 
	char designation;
	int salary;
	printf("Enter emplyoee name: ");
	scanf("%s",&name);
	printf("Enter designation (m, c, p)");
	fflush(stdin);
	scanf("%c",&designation);
	switch(designation)
	{
		case 'm':
			salary = 50000;
			break;
		case 'c':
		    salary = 20000;
		    break;
		case 'p':
			salary = 10000;
			break;
		default:
		     printf("\nInvaild designation ");
			 break;
			 	 	 		
	}
	printf("\nemplyoee name = %s", name);
	printf("\nsalary = %d", salary);
}

//ALGORITHM
//1. start
//2. Accept name, designation, salary
//3. if designation is m then
//     3.1) salary = 50000
//4. if designation is c then
//     4.1) salary = 20000
//5. if designation is p then
//     5.1) salary = 10000
//6. if designation is not between (m,c,p) then
//     6.1) print "Invalid designation"
//7. stop     
