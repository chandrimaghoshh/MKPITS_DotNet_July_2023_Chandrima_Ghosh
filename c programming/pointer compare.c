#include<stdio.h>
void main()
{
	char n1[20];
	char n2[20];
	char *ptr1;
	char *ptr2;
	printf("Enter name1: ");
	gets(n1);
	ptr1=n1;
	printf("Enter name2: ");
	gets(n2);
	ptr2=n2;
	while(*ptr1!='\0' || *ptr2!='\0')
	{
		if(*ptr1==*ptr2)
		{
			printf("string is equal: ");
			break;	
		}
		else
		{
		printf("string is not equal: ");
		break;
		}
	}
}
//ALGORITHM
//1. start
//2. declare n1[20],n2[20],*ptr1,*ptr2
//3. Accept name1, name2
//4. check *ptr1!=0 and *ptr!=0
//5. if *ptr1==*ptr2 then,
//   5.1) print "string is equal"
//   5.2) break
//6. else print "string is not equal"
//7. stop
