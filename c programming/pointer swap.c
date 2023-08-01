#include<stdio.h>
void main()
{
	int n1=14;
	int n2=10;
	int *p1=&n1;
	int *p2=&n2;
	printf("\nBefore swap: *p1=%d, *p2=%d",*p1,*p2);
	*p1=*p1+*p2;
	*p2=*p1-*p2;
	*p1=*p1-*p2;
	printf("\nAfter swap: *p1=%d, *p2=%d",*p1,*p2);
}

//ALGORITHM
//1. start
//2. n1=10,n2=20,*p1=&n1,*p2=&n2
//3. print "*p1,*p2
//4. *p1=*p1+*p2
//5. *p2=*p1-*p2
//6. *p1=*p1-*p2
//7. print "*p1*p2
//8. stop
