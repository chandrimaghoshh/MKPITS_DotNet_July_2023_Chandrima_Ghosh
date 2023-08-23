#include<iostream>
using namespace std;
class employee
{
	public:
		int emp_no;
		string emp_name;
		employee()
		{
			emp_no = 1410;
			emp_name = "Chandrima";
		}
		void display()
		{
			cout<<"Emp No. : "<<emp_no<<endl;
			cout<<"Emp Name : "<<emp_name<<endl;
		}
};
int main()
{
	employee emp1;
	emp1.display();
	return 0;
}
