#include<stdio.h>
int main()
{
    int m1, m2, m3, total;
    float per;
	printf("Enter 3 subject marks\n ");
	scanf("%d%d%d",&m1,&m2,&m3);
	total = m1 + m2 + m3;
	per = (total/300.f) * 100.0f;
	printf("total = %d\n",total);
	printf("per = %f\n",per);
	if(per>=75)
	{
		printf("grade = distinction");
	}
	else if(per>=60 && per<=75)
	{
		printf("grade = first");
	}
	else if(per>=40 && per<=65)
	{
		printf("grade = second");
	}
	else
	{
		printf("grade = fail");
	}
	return 0;
}

//ALGORITHM
//1. start
//2. Accept m1, m2, m3, total, per
//3. check if per>=75 then
//     3.1) print "grade is disticntion"
//     3.2) goto step       
//4. check else if per>=60 and per<=75 then
//     4.1) print" grade is first"
//5. else if per>=40 and per<=75 then
//      5.1 print "grade is second"
//6. else print "fail"

