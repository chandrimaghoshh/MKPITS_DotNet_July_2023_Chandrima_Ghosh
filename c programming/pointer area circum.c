#include<stdio.h>
void calculate(int r, float *a, float *c)
{
	*a=3.14f*r*r;
	*c=2*3.14f*r;
}
void main()
{
	float radius,area,circ;
	printf("Enter radius: ");
	scanf("%f",&radius);
	calculate(radius,&area,&circ);
	printf("\nArea of circle=%f",area);
	printf("\nCircumference=%f",circ);
}

//ALGORITHM
//1. start
//2. define calculate factorial
//3. declare r,*a,*c
//4. *a=3.14f*r*r
//5. *c=2*3.14*r
//6. go to main function
//7. declare radius,area,circ
//8. Accept radius
//9. call function calculate(radius,&area,&circ)
//10. print "area" and "circ"
//11. stop 

