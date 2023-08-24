#include<iostream>
using namespace std;
class Account
{
	public:
		int act_no;
		int bal;
		virtual void deposit(int amt)
		{
			cout<<"Hello to account deposit"<<endl;
		}
};
class saving : public Account
{
	public:
		void deposit(int amt)
		{
			int interest = 500;
			bal = bal+amt+interest;
			cout<<"Balance with interest : "<<bal<<endl;
		}
};
class current : public Account
{
	public:
		void deposit(int amt)
		{
			bal = bal+amt;
			cout<<"Current Balance : "<<bal<<endl;
		}
};
int main()
{
	Account A1;
	Account *A;
	Account a;
	saving s;
	current c;
	
	A = &a;
	A->act_no;
	A->bal;
	A->deposit(500);
	A = &s;
	A->act_no = 123;
	A->bal = 1000;
	A->deposit(500);
	
	A = &c;
	A->act_no = 143;
	A->bal = 4000;
	A->deposit(500);
	return 0;
}
