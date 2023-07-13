#include<stdio.h>
void main()
{
	int English, Maths, Science, total;
	printf("English ");
	scanf("%d",&English);
	printf("Maths ");
	scanf("%d",&Maths);
	printf("Science ");
	scanf("%d",&Science);
	total = English + Maths + Science;
	printf("total = %d", total);
}
