#include<stdio.h>
void main()
{
	char ch;
	printf("Enter character: ");
	scanf("%c",&ch);
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
//2. Accept ch
//3. if ch is a then
//     3.1) print "it is vowel"
//4. if ch is e then
//     4.1) print "it is vowel"
//5. if ch is i then
//     5.1) print "it is vowel"
//6. if ch is o then
//     6.1) print "it is vowel"
//7. if ch is u then
//     7.1) print "it is vowel"
//8. if ch is not in (a, e, i, o, u) then
//     8.1) print "it is not vowel"
//8.stop
