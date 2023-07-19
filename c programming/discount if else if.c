
#include<stdio.h>
void main()
{
    char customer_name[10], product_name[10];
	int price, quantity, discount, total_amount;
	printf("Enter customer_name ");
	scanf("%s",&customer_name);
	printf("Enter product_name ");
	scanf("%s",&product_name);
	printf("Enter price = ");
	scanf("%d",&price);
	printf("Enter quantity = ");
	scanf("%d",&quantity);
	total_amount = price * quantity;
	printf("total_amount = %d\n", total_amount);
	if(total_amount>=1000)
	{
	    discount = total_amount * 0.4;
	}
	else if(total_amount>=500)
	{
		discount = total_amount * 0.25;
	}
	else
	{
		discount = total_amount * 0.1;
	}
	printf("\ncustomer_name = %s", customer_name);
	printf("\nproduct_name = %s", product_name);
	printf("\nprice = %d", price);
	printf("\nquantity = %d", quantity);
	printf("\ndiscount = %d", discount);
	total_amount = total_amount - discount;
	printf("\ntotal amount = %d", total_amount);
	
}

//ALGORITHM
//1. start
//2. customer_name, product_name, price, quantity, discount, total amount,
//3. check if total_amount is greater than or equal to 10000 then
//     3.1) discount is equal to total amount multiply by 0.4       
//4. else if total_amount is greater than or equal to 500 then
//     4.1) discount is equal to total_amount is multiply by 0.25
//5. else discount is equal to total_amount is multiply by 0.1
//6. stop

