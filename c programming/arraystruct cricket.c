#include<stdio.h>
#include<string.h>
struct cricket
{
	int run;
	char name[20];
};
void main()
{
	struct cricket cri[11];
	int counter,sum=0;
	for(counter=0;counter<11;counter++)
	{
		printf("Enter Players Name and Runs : ");
		scanf("%s%d",&cri[counter].name,&cri[counter].run);
	}
	printf("\nEnter score details : ");
	for(counter=0;counter<11;counter++)
	{
		printf("\nPlayers Name = %s\t",cri[counter].name);
		printf("Runs = %d\t",cri[counter].run);
	}
	for(counter=0;counter<11;counter++)
	{
		sum=sum+cri[counter].run;
	}
	printf("\nTotal run scored by team = %d",sum);
}
//ALGORITHM
//1.start
//2.define function struct cricket
//3.declare run,name
//4.got to main function
//5.call function struct cricket cri[11]
//6.declare counter,sum=0
//7.for counter=0;counter<11;counter++ then,
//8.print name,run
//9.for counter=0;counter<11;counter++ then,
//10.sum=sum+run
//11.print sum
//12.stop

