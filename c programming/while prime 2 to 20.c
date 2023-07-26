#include<stdio.h>
#include<math.h>
void main()
{
	int start, end, count, flag,num;
	printf("Enter start and end value\n");
	scanf("%d%d",&start,&end);
	
	printf("\n\nPrime numbers from %d to %d are:\n",start, end);
	while(start<=end)
	{
		num=sqrt(start);
		count=2;
		flag=1;
		while(count<=num)
		{
			if(start%count==0)
			{
				flag=0;
				break;
			}
			count++;
		}
		if(flag==1)
		{
			printf("%d, ", start);
	    }
		start++;	
	}
	printf("\n\n");
}

//ALGORITHM
//1. start
//2. Declare start, end, count, flag,num
//3. Accept start and end value
//4. print "prime number from 2 to 20 are"
//5. while count<=num
//6. if start%count==0 then,
//    6.1) flag=0
//    6.2) break
//    6.3) count++
//7. if flag==1
//    7.1) print "start"
//8. print "\n\n"
//9. stop 

