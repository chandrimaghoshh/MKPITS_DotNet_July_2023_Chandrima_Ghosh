//Function without parameters and return value

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
	printf("Area of square=%d",result);
	
}

//ALGORITHM
//1. start
//2. define main function 
//3. declare area=side*side
//4. print area
//5. return result 
//6. go to main function
//7. call function area
//7. result=area()
//8. stop
