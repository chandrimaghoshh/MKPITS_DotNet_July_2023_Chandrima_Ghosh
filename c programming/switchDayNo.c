#include<stdio.h>
void main()
{
	int day_no;
	printf("Enter day_no: ");
	scanf("%d",&day_no);
	switch(day_no)
	{
		case 1:
			printf("\nMonday");
			break;
		case 2:
		    printf("\nTuesday");
		    break;
		case 3:
			printf("\nWednesday");
			break;
		case 4:
			printf("\nThursday");
			break;
		case 5:
		    printf("\nFriday");
			break;
		case 6:
		     printf("\nSaturday");
			 break;
		case 7:
		     printf("\nSunday");
			 break;
		default:
		     printf("\nInvaild day_no");
			 break;
			 	 	 		
	}
}

//ALGORITHM
//1. start
//2. Accept day-no
//3. if day_no is equal to 1 then
//    3.1) print "Monday"
//4.if day_no is equal to 2 then
//    4.1) print "Tuesday"
//5. similarly check for other day_no
//6. if day_no is not between 1 to 7 then
//    6.1) print "Invaild day_no"
//7. stop 
