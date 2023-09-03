#include<iostream>
using namespace std;
class Employee
{
	public:
		int Manager_salary;
		int Developer_salary;
		virtual void salary()=0;		
};
class Manager : public Employee
{
	public:
		void salary()
		{
			cout<<"Salary of Manager :"<<Manager_salary<<endl;
		}
};
class Developer : public Employee
{
	public:
		void salary()
		{
			cout<<"Salary of Developer : "<<Developer_salary<<endl;
		}
};
int main()
{
	Employee *E;
	Manager m;
	E=&m;
	E->Manager_salary=60000;
	E->salary();
	
	Developer d;
	E=&d;
	E->Developer_salary=50000;
	E->salary();
	return 0;
	
}
