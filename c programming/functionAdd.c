#include<stdio.h>
void addition(int n1, int n2)
{
	int result=n1+n2;
	printf("Adition of 2 num=%d",result);
}
void main()
{
	int n1, n2;
	printf("Enter 2 num:");
	scanf("%d%d",&n1,&n2);
	addition(n1,n2);
	printf("\nBye");
}

//ALGORITHM
//1. start
//2. define the function addition
//   2.1) result=n1+n2
//   2.1) print "result"
//3. goto main function
//4. declare n1, n2
//5. print calling function
//6. addition(n1,n2)
//7. print "Bye"
//8. stop
