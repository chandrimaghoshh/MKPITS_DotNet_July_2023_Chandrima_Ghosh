#include<stdio.h>
void main()
{
	int count=0;
	char name[20];
	char *ptr;
	printf("Enter Name: ");
	gets(name);
	ptr=name;
	while(*ptr!='\0')
	{
		if(*ptr=='a' || *ptr=='e' || *ptr=='i' || *ptr=='o' || *ptr=='u')
		{
			count=count+1;
		}
		ptr++;
	}
	printf("Numbers of vowels in a string=%d",count);
}

//ALGORITHM
//1. start
//2. declare count=0,name[20],*ptr
//3. Accept name
//4. check *ptr!=0 then,
//5. if *ptr=='a' || *ptr=='e' || *ptr=='i' || *ptr=='o' || *ptr=='u' then,
//    5.1) count=count+1
//    5.2) ptr++
//6. print "count"
//7. stop
