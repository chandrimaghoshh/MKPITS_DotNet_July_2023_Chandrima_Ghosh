#include<iostream>
using namespace std;
class employee
{
	public:
		int emp_no;
		string emp_name;
		employee(int eno, string enam)
		{
			emp_no = eno;
			emp_name =enam; 
		}
		void display()
		{
			cout<<"Emp No. : "<<emp_no<<endl;
			cout<<"Emp Name : "<<emp_name;
		}
};
int main()
{
	int eno;
	int enam;
	employee emp1(12, "Chandrima");
	emp1.display();
	return 0;
}
