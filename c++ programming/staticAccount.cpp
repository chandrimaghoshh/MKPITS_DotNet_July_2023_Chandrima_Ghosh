#include<iostream>
using namespace std;
class Account
{
	public:
		int act_no;
		int bal;
		static float roi;
		Account(int act_no, int bal)
		{
			this-> act_no = act_no;
			this-> bal = bal; 
		}
		void display()
		{
			cout<<"Account No. : "<<act_no<<endl;
			cout<<"Balance : "<<bal<<endl;
			cout<<"Rate of interest : "<<roi<<endl;
		}
};
float Account :: roi = 9.5f;
int main()
{
	Account A1 = Account(123,2000);
	Account A2 = Account(157,3000);
	A1.display();
	A2.display();
	return 0;
}
