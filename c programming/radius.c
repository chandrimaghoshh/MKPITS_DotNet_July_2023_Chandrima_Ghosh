#include<stdio.h>
void main()
{
	float radius, area, circ;
	printf("Enter radius ");
	scanf("%f",&radius);
	area = 3.14f * radius* radius;
	circ = 2 * 3.14f * radius;
	printf("area = %f\n", area);
	printf("circ = %f", circ);
}
