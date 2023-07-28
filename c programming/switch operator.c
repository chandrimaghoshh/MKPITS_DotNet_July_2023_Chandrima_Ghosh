#include<stdio.h>
void main()
{
	int num1,num2,result=0;
	char op;
	printf("Enter 2 numbers: ");
	scanf("%d%d",&num1,&num2);
	printf("Enter(+,-,*,/):");
	fflush(stdin);
	scanf("%c",&op);
	switch(op)
	{
		case '+':
			result=num1+num2;
			break;
		case '-':
		    result=num1-num2;
		    break;
		case '*':
			result=num1*num2;
			break;
		case '/':
			result=num1/num2;
			break;	
		default:
		     printf("Invaild op");
			 break;		 	 	 		
	}
	printf("\nresult=%d",result);
}
	
	

//ALGORITHM
//1. start
//2. Accept num1, num2, result
//3. if op is + then
//     3.1) result = num1 + num2
//4. if op is - then
//     4.1) result = num1 - num2
//5. if op is * then
//     5.1) result = num1 * num2
//6. if op is / then
//    6.1) result = num1 / num2
//7. if op is not similar to (+, -, *, /) then
//    7.1 print "Invaild op"
//8.stop
