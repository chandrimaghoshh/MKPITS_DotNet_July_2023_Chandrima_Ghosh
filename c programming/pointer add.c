#include<stdio.h>
void addition(int n1, int n2, int *result)
{
	 *result=n1+n2;	
}
void main()
{
	int n1,n2,result;
	printf("Enter 2 numbers: ");
	scanf("%d%d",&n1,&n2);
	addition(n1,n2,&result);
	printf("Addition=%d",result);
	
}
//ALGORITHM
//1. start
//2. define function addition
//3. *result=n1+n2
//4. go to main function
//5. call function addition(n1,n2,&result)
//6. print result
//7. stop

