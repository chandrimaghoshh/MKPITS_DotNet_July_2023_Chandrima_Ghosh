#include<stdio.h>
void main()
{
	int num=5;
	int *ptr=&num;
	printf("Address=%x\n",ptr);
	printf("Value of address=%d",*ptr);
}

//ALGORITHM
//1. start
//2. declare num=5,*ptr=&num
//3. print "ptr"
//4. print "*ptr"
//5. stop

//ALGORITHM
//1. start
//2. declare num=5,*ptr=num
//3. print "ptr"
//4. print "*ptr"
//5. stop
