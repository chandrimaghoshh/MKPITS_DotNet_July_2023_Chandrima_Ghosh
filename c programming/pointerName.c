#include<stdio.h>
#include<string.h>
void main()
{
	char name[20];
	char *ptr;
	
	printf("Enter Name: ");
	gets(name);
	ptr=name;
	
	while(*ptr!= '\0')
	{
		printf("%c",*ptr);
		ptr++;
	}
}

//ALGORITHM
//1. start
//2. declare name[20],*ptr
//3. Accept name
//4. ptr=name
//5. check *ptr!=0
//6. print "*ptr
//7. stop
