#include<stdio.h>
#include<string.h>
struct  balance
{
	char name[20];
	int acc_no,balance;
};
void main()
{
	struct balance bal[3];
	int counter;
	for(counter=0;counter<3;counter++)
	{
		printf("Enter Name, Acc.No, Balance : ");
		scanf("%s%d%d",&bal[counter].name,&bal[counter].acc_no,&bal[counter].balance);
	}
	
	printf("Account with balance less than 100 rs : ");
	for(counter=0;counter<3;counter++)
	{
		if(bal[counter].balance<100)
		{
		printf("Name = %s\tAccount no.= %d\t",bal[counter].name,bal[counter].acc_no);
		}
	}
}
//ALGORITHM
//1.start
//2.define function struct balance
//3.declare name,acc_no,balance
//4.go to main function
//5.call function struct balance bal[3]
//6.declare counter
//7.for counter=0;counter<3;counter++
//8.Accept name,acc_no,balance 
//9.print account with balance less than 100rs:
//10.check if bal[counter].balance<100 then,
//11.print name,acc_no
//12.stop
