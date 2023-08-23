#include<stdio.h>
void main()
{
	int i; 
	int num1=0;
	int num2=1;
	int add=num1+num2;
	printf("%d,%d", num1, num2);
	for(i=3;i<=10;i++)
	{
		printf(",%d",add);
		num1=num2;
		num2=add;
		add=num1+num2;
	}
}

//ALGORITHM
//1. start
//2. Declare num1=0, num2=1, add=num1+num2
//3. Accept num1, num2
//4. print "num1, num2"
//5. for i=3;i<=10;i++ then
//6. print "add" then,
//    6.1) num1=num2
//    6.2) num2=add
//    6.3) add=num1+num2
//7. stop 
