#include<stdio.h>
void main()
{
    char customer name[10], product name[10];
	int price, quantity, discount, total amt;
	printf("Enter customer name \n ");
	scanf("%s",&customer name);
	printf("Enter product name\n  ");
	scanf("%s",&product name);
	printf("Enter price =\n ");
	scanf("%d",&price)
	printf("Enter quantity =\n ");
	scanf("%d",&quantity);
	total amount = price * quantity;
	printf("total amt = %d", total amt);
	if(total amt>=1000)
	{
	    discount = 40%;
	}
	else if(total amt>=500 && salary<=1000)
	{
		discount = 25%;
	}
	else
	{
		bonus = 10%;
	}
	printf("employee = %s", name);
	printf("\nsalary = %d", salary);
	printf("\nbonus = %d", bonus);
}

//ALGORITHM
//1. start
//2. Accept m1, m2, m3, total, per
//3. check if per is greater than equal to 75 then
//     3.1) print "grade is disticntion"      
//4. check else if per is greater than equal to 60 and per is less than equal to 75 then
//     4.1) print" grade is first"
//5. else if per greater than equal to 40 and per is less than equal to 75 then
//      5.1 print "grade is second"
//6. else print "fail"
//7. stop

