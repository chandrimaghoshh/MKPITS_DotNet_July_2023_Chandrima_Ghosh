#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		 void deposit(int amt)
		 {
		 	cout<<"Hello depossit "<<endl;
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
		void deposit(int amt)
		{
			bal = bal+amt;
			cout<<"Current balance without interest = "<<bal<<endl;
		}
};
int main()
{
	Account *A;
	
	Saving s;
	A=&s;
	A->actno = 123;
	A->bal = 1000;
	A->deposit(500);
	
	Current c;
	A=&c;
	A->actno = 234;
	A->bal = 1000;
	A->deposit(500);
	return 0;
}
