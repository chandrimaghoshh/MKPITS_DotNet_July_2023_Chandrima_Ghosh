#include<stdio.h>
void main ()
{
   int num[5];
   int i, j, a, n;
   printf("Enter num of elements: ");
   scanf("%d", &n);
   printf("Enter number: ");
   for (i=0; i<n;i++)
      scanf("%d", &num[i]);
   for (i=0; i<n;i++)
   	{
      for (j=i+1;j<n;j++)
	  {
         if (num[i] < num[j])
		{
            a = num[i];
            num[i] = num[j];
            num[j] = a;
         }
      }
   }
   printf("Descending order is: ");
   for (i=0;i<n;i++)
   {
      printf("%d", num[i]);
   }
}
//ALGORITHM
//1. start
//2. declare arr[5],i,j,a,n
//3. Accept  n
//4. for i=0;i<n;i++
//    4.1) num[i]
//5. for i=0;i<n;i++
//6. for j=i+1;j<n;j++
//7. check if num[i]<num[j]
//    7.1) a=num[i]
//    7.2) num[i]=num[j]
//    7.3) num[j]=a
//8. printf("Ascending order is"
//9. for i=0;i<n;i++
//10. print "num[i]"
//11. stop
