#include<stdio.h>
int main()
{
	int month;
	int days;
	printf("Enter month(1 - 12) : ");
	scanf("%d",&month);
	switch(month)
	{
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:	
			 printf("\n month has 31 days");
		     break;
		case 4:
		case 6:
		case 9:
		case 11:
		     printf("\n month has 30 days");
		     break;
		case 2:     
		     printf("\nMonth can have either 28 or 29 days");
		     break;
		default:
		     printf("Invild month");     
    }
    return 0;
}

//ALGORITHM
//1. start
//2. Accept month
//3. if 1, 3, 5, 7, 8, 10, 12 has 31 days then
//    3.1) print "month has 31 days"
//4.if 4, 6, 9, 11 has 30 days then
//    4.1) print "month has 30 days"
//5. if 2 has 28 or 29 days then
//    5.1) print "month can have 28 or 29 days"
//6. stop 
