#include<iostream>
using namespace std;
class account
{
	public:
		int actno;
		int bal;
		int interest;
	void getdata(int a, int b, int c)
	{
		actno = a;
		bal = b;
		interest = c;
	}	
};
class saving : public account
{
	public:
		int deposit(int amt)
		{
			bal = bal+interest+amt;
			return bal;
		}
};
class current : public account
{
	public:
		int deposit(int amt)
		{
			bal = bal+amt;
			return bal;
		}
};
int main()
{
	saving s1;
	current c1;
	int result;
	int actno,bal,interest,amount;
	cout<<"Enter Account Details : ";
	cin>>actno>>bal>>interest>>amount;
	s1.getdata(amount,bal,interest);
	result = s1.deposit(amount);
	cout<<"Saving Balance with interest: "<<result<<endl;
	
	c1.getdata(amount,bal,interest);
	result = c1.deposit(amount);
	cout<<"Current Balance : "<<result;
	return 0;
}
