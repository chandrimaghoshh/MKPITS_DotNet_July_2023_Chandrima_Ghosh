#include<stdio.h>
void main()
{
	int count=0;
	char name[20];
	char *ptr;
	printf("Enter name1: ");
	gets(name);
	ptr=name;
	while(*ptr!='\0')
	{
		count=count+1;
		ptr++;
	}
	printf("Length of string is = %d",count);
}

//ALGORITHM
//1. start
//2. declare count=0,name[20],*ptr
//3. Accept name
//4. ptr=name
//5. check *ptr!=0 then,
//    5.1)count=count+1
//6. print "count"
//7. stop
