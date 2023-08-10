#include<iostream>
using namespace std;
class bank
{
	public:
		int acc_no;
		int bal;
		bank(int acc_no,int bal)
		{
			this->acc_no=acc_no;
			this->bal=bal;
		}
		getDeposite()
		{
			int amt;
			cout<<"Enter deposit amt : ";
			cin>>amt;
			bal=bal+amt;
			cout<<"Total amount : "<<bal<<endl;
			return amt;
		}
		getWithdrawal()
		{
			int amt;
			cout<<"Enter withdrawal amt : ";
			cin>>amt;
			bal=bal-amt;
			cout<<"Total amount : "<<bal;
			return amt;
		}
};
int main()
{
	int acc_no,bal;
	bank b1(acc_no,bal);
	cout<<"Enter account no and balance : ";
	cin>>b1.acc_no>>b1.bal;
	b1.getDeposite();
	b1.getWithdrawal();
	return 0;
}
