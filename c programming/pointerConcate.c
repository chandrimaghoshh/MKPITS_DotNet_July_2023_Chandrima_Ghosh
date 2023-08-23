#include<stdio.h>
void main()
{
	char name1[20];
	char name2[20];
	char *ptr1=name1;
	char *ptr2=name2;
	printf("Enter Name: ");
	gets(name1);
	printf("Enter Surname: ");
	gets(name2);
	while(*ptr1!='\0')
	{
		ptr1++;
	}
	while(*ptr2!='\0')
	{
		*ptr1=*ptr2;
		ptr1++;
		ptr2++;
	}
	*ptr1='\0';
	printf("Concatenation of 2 strings = %s ",name1);
}

//ALGORITHNM
//1. start
//2. declare name1,name2,*ptr1,*ptr2
//3. Accept name
//4. ptr1=name1
//5. ptr2=name2
//6. check *ptr1!=0 then,
//    6.1) ptr1++;
//7. check *ptr2!=0 then,
//    7.1) *ptr1=*ptr2++
//7. print "name1"
//8. stop
