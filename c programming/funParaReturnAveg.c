//Function with parameters and returning value

#include<stdio.h>
int average(int n1, int n2, int n3, int n4, int n5)
{
	int add=n1+n2+n3+n4+n5;
	int result=add/5;
	printf("Addition of 5 numbers=%d\n",add);
	printf("Average=%d",result);
	return result;
}
void main()
{
	int n1,n2,n3,n4,n5,result;
	printf("Enter number: ");
	scanf("%d%d%d%d%d",&n1,&n2,&n3,&n4,&n5);
	result=average(n1,n2,n3,n4,n5);
}

//ALGORITHM
//1. start
//2. define function average
//3. add=n1+n2+n3+n4+n5
//4. print "add"
//5.result=add/5
//   5.1) return result
//6. go to main function
//7. declare n1,n2,n3,n4,n5,add,result
//7. result=call average
//8. stop
