#include<stdio.h>
int main()
{
	int n1, n2, n3;
	printf("Enter 3 numbers ");
	scanf("%d%d%d",&n1,&n2,&n3);
	if(n1>n2 && n1>n3)
	{
		printf("n1 is greater");
	}
	else if(n2>n3)
	{
		printf("n2 is greater");
	}
	else
	{
		printf("n3 is greater");
	}
	return 0;
}

//ALGORITHM
//1. start
//2. Accept 3 numbers, input n1, n2, n3
//3. if check whether n1 is greater than n2 and n1 is greater than n3
//      3.1) print "n1 is greater"
//4. else if n2 is greater than n3
//      4.1) print "n2 is greater"
//      4.2) goto step 6
//5. else "n3 is greater"
//6. stop
