//Function without parameters and not returning value

#include<stdio.h>
void area()
{
	int side,result;
	printf("Enter sides: ");
	scanf("%d",&side);
	result=side*side;
	printf("Area of square=%d\n",result);
}
void main()
{
	int result;
	area();
}
//ALGORITHM
//1. start
//2. define main function 
//3. declare side
//4. Accept side
//5. result=side*side
//6. go to main function
//7. call function area
//8. result=area()
//9. stop
