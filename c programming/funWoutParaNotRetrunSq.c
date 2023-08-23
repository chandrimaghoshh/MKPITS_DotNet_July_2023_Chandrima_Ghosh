//Function without parameters and returning value

#include<stdio.h>
int area()
{
	int side;
	printf("Enter sides: ");
	scanf("%d",&side);
	int result=side*side;
	return result;
}
void main()
{
	int result;
	result=area();
	printf("Result=%d\n",result);
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
