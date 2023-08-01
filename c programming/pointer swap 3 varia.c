#include<stdio.h>
void main()
{
	int temp;
	int n1=10;
	int n2=20;
	int *p1=&n1;
	int *p2=&n2;
	
	printf("\nBefore swap: *p1=%d,*p2=%d",*p1,*p2);
	
	temp=*p1;
	*p1=*p2;
	*p2=temp;
	
	printf("\nAfter swap: *p1=%d,*p2=%d",*p1,*p2);
	
}

//ALGORITHM
//1. start
//2. n1=10,n2=20,*p1=&n1,*p2=&n2
//3. print "*p1,*p2
//4. temp=*p1
//5. *p1=*p2
//6. *p2=temp
//7. print "*p1*p2
//8. stop
