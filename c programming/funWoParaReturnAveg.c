//Function without parameters and returning value

#include<stdio.h>
int average()
{
	float n1,n2,n3,n4,n5,add;
	float result;
	printf("Enter 5 numbers: ");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	add=n1+n2+n3+n4+n5;
	printf("Addition of 5 numbers=%f\n",add);
	result=add/5;
	return result;
}
void main()
{
		float result;
		result=average();
		printf("Average = %f\n",result);
}

//ALGORITHM
//1. start
//2. define function average
//3. declare n1,n2,n3,n4,n5,add,result
//4. add=n1+n2+n3+n4+n5
//5. print "add"
//6.result=add/5
//   6.1) return result
//7. go to main function
//8. call average
//9. stop
