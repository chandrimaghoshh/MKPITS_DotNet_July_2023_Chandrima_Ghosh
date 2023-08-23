//Function with parameters and not returning value

#include<stdio.h>
void average(int n1, int n2, int n3, int n4, int n5)
{
	int add=n1+n2+n3+n4+n5;
	int result=add/5;
	printf("Addition of 5 numbers=%d",add);
	printf("\nResult=%d",result);
	
}
void main()
{
	int n1,n2,n3,n4,n5,result,add;
	printf("Enter 5 numbers: ");
	scanf("%d%d%d%d%d",&n1,&n2,&n3,&n4,&n5);
	average(n1,n2,n3,n4,n5);
}

//ALGORITHM
//1. start
//3. define function oddeven
//4. declare num,rem=0
//5. Accept num
//6. check if num%2==0 then,
//    6.1) print "it is even number"
//else print "it is odd number
//7. go to main function
//8. call oddeven
//9. stop
