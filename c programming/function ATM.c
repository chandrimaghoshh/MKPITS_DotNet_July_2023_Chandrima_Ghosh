#include<stdio.h>
void deposit(int amt, int bal);
void withdrawal(int amt, int bal);
void main()
{
	int amt, bal=1000;
	printf("Enter amount : ");
	scanf("%d",&amt);
	deposit(amt,bal);
	withdrawal(amt,bal);
}
void deposit(int amt,int bal)
{
	bal=bal+amt;
	printf("Amount deposited = %d\n",bal);
}
void withdrawal(int amt,int bal)
{
	bal=bal-amt;
	printf("Amount withdrawal = %d\n",bal);
}

//ALGORITHM
//1. start
//2. define function deposit,withdrawal
//3. declare amt, bal=1000
//4. Accept amt
//5. deposit(amt,bal)  withdrawal(amt,bal)
//6. got to main fuction
//7. call function deposite
//    7.1)bal=bal+amt
//    7.2)print bal
//8. call function withdrawal
//    8.1)bal=bal-amt
//    8.2)print bal
//9. stop
