#include<stdio.h>
void sayhello()
{
	printf("Hello\n");
}
void main()
{
	printf("Calling function:\n");
	sayhello();
	
	printf("Back to main function:\n");
	sayhello();
	
	printf("\nBye");
}

//ALGORITHM
//1. start
//2. define function sayhello
//     2.1) print "Hello"
//3. goto main function
//4. print calling function
//5. call function sayhello
//6. print back in main function
//7. print "Bye"
//8. stop
