#include<stdio.h>
void prime(int counter, int num, int rem)
{
	while(counter<num)
	{
		rem = num%counter;
	if(rem == 0)
	{
		printf("it is not a prime number");
	break;
	}
	counter = counter+1;
	}
	if(num == counter)
	{
	printf("it is  prime number");
	}
}
    void  main()
{
	int counter = 2, num, rem=0;
	printf("Enter number: ");
	scanf("%d",&num);
	prime(counter,num,rem);
}
//ALGORITHM
//1. start
//2. define function prime
//3. while counter<num then
//   3.1)rem=num%counter
//4. if rem==0 then
//    4.1) print "it is not prime number"
//    4.2) counter=counter+1
//5. if num==counter
//    5.1) print "it is prime number"
//6. calling function
//7. prime(counter,num,rem)
//8. stop
