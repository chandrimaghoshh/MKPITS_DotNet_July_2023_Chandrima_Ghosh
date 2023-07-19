#include<stdio.h>
void main()
{
	char ch;
	printf("Enter character: ");
	scanf("%c",&character);
	fflush(stdin);
	switch(ch)
	{
		case 'a':
			printf("it is vowel");
			break;
		case 'e':
		    printf("it is vowel");
		    break;
		case 'i':
			printf("it is vowel");
			break;
		case 'o':
			printf("it is vowel");
			break;
		case 'u':
		    printf("it is vowel");	
		default:
		     printf("\nit is not vowel ");
			 break;
			 	 	 		
	}
}
	
	

//ALGORITHM
//1. start
//2. Accept num1, num2, result
//3. if op is + then
//     3.1) result = num1 + num2
//4. if op is - then
//     4.1) result = num1 - num2
//5. if op is * then
//     5.1) result = num1 * num2
//6. if op is / then
//    6.1) result = num1 / num2
//7. if op is not similar to (+, -, *, /) then
//    7.1 print "Invaild op"
//8.stop
