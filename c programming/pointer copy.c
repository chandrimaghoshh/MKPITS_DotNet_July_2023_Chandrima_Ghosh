#include<stdio.h>
void main()
{
	char name1[20];
	char name2[20];
	char *ptr1;
	char *ptr2;
	printf("Enter name: ");
	gets(name1);
	ptr1=name1;
	ptr2=name2;
	while(*ptr1!='\0')
	{
		*ptr2=*ptr1;
		ptr1++;
		ptr2++;
	}
	*ptr2='\0';
	printf("Copy name = %s",name2);
}

//ALGORITHNM
//1. start
//2. declare name1,name2,*ptr1,*ptr2
//3. Accept name
//4. ptr1=name1
//5. ptr2=name2
//6. check *ptr1!=0 then,
//    6.1) *ptr1=*ptr2
//7. print "name2"
//8. stop
