//Function with parameters and returning value
#include<stdio.h>
int area(int side,int result)
{
	int area=side*side;
	printf("Area of square=%d",area);
	return result;
}
void main()
{
	int result=0,side;
	printf("Enter num: ");
	scanf("%d",&side);
	result=area(side,result);
	
}
//ALGORITHM
//1. start
//2. define main function 
//3. declare area=side*side
//4. print area
//5. return result 
//6. go to main function
//7. call function area
//7. result=area(side,result)
//8. stop
