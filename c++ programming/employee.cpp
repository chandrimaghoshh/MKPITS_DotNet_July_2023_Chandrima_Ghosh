#include<iostream>
using namespace std;
class employee
{
	public:
		int number;
		int salary;
		string name;
		string desig;
	void getEmployee_Details()
	{
		cout<<"Number "<<"Salary "<<"Name "<<"desig ";
		cin>>number>>salary>>name>>desig;
	}
	void displayEmployee_Details()
	{
		cout<<"Number : "<<number<<endl;
		cout<<"Salary : "<<salary<<endl;
		cout<<"Name : "<<name<<endl;
		cout<<"Desig : "<<desig<<endl;
	}
};
int main()
{
	employee emp1,emp2;
	cout<<"Employee 1 : "<<endl;
	emp1.getEmployee_Details();
	emp1.displayEmployee_Details();
	cout<<"Employee 2 : "<<endl;
	emp2.getEmployee_Details();
	emp2.displayEmployee_Details();
	return 0;
	
}
