#include<stdio.h>
void operator(int n1, int n2,char op)
{
	int result=0;
	switch (op)
	{
		case '+':
			result=n1+n2;
			break;
		case '-':
		    result=n1-n2;
		    break;
		case '*':
			result=n1*n2;
			break;
		case '/':
			result=n1/n2;
			break;	
		default:
		     printf("Invaild op");
			 break;		 	 	 		
	}
	printf("Result=%d\n",result);
}
void main()
{
	int n1,n2,result=0;
	char op;
	char ch='y';
	while(ch='y')
	{
		printf("Enter 2 numbers: ");
		scanf("%d%d",&n1,&n2);
		printf("Enter(+,-,*,/):");
		fflush(stdin);
		scanf("%c",&op);
		operator(n1,n2,op);
		printf("do you want to continue,press y: ");
		fflush(stdin);
		scanf("%c",&ch);
	}
}
//ALGORITHM
//1. start
//2. define the function operator
//   2.1) result=0
//   2.1) print "result"
//3. goto main function
//4. declare n1, n2,result=0
//    4.1)char op
//    4.2)ch='y'
//    4.3)while(ch='y')
//5. print calling function
//6. operator(n1,n2,op)
//7. print "do you want to continue,press y"
//8. stop	
