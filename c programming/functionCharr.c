#include<stdio.h>
void addition(int n1, int n2)
{
	int result=n1+n2;
	printf("Addition of 2 number=%d",result);
}
void main()
{
	char ch='y';
	do
	{
		int num1, num2;
		printf("Enter 2 num:");
		scanf("%d%d",&num1,&num2);
		addition(num1,num2);
		printf("\ndo you want to continue,press y:");
		fflush(stdin);
		scanf("%c",&ch);
	 }
	 while(ch=='y');
	
}

//ALGORITHM
//1. start
//2. define the function addition
//   2.1) result=n1+n2
//	 2.2) print "result"
//3. ch='y'
//4. declare num1, num2
//5. calling function
//6. addition(num1,num2)
//7. print "do you want to continue,press y"
//8. while ch=='y'
//9. stop 
