#include<stdio.h>
void main()
{
	int num;
	printf("Enter num ");
	scanf("%d",&num);
	switch(num%2==0)
	{
		case 1:
			printf("%d is even", num);
			break;
		default:
		    printf("%d is odd", num);
			break;	
			
	}
}

//1. start
//2. Accept num
//3. if num is devided by 2 or equal to zero then
//     3.1) print "even"
//4. if num is not devided by 2 or equal to zero then
//     4.1) print "odd"
//5. stop
