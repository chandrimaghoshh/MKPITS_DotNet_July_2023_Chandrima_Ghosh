#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		void deposit(int amt)
		{
			cout<<"Hello to account deposit"<<endl;
		}
};
class Saving : public Account
{
	public:
		void deposit(int amt)
		{
			int interest=500;
			bal = bal+amt+interest;
			cout<<"Balance with interest = "<<bal<<endl;
		}
};
class Current : public Account
{
	public:
		void current(int amt)
		{
			bal = bal+amt;
			cout<<"Current balance without interest = "<<bal<<endl;
		}
};
int main()
{
	Account a;
	a.deposit(1000);
	
	Saving s;
	s.actno = 123;
	s.bal = 1000;
	s.deposit(500);
	
	Current c;
	c.actno = 234;
	c.bal = 1000;
	c.current(500);
	return 0;
}
