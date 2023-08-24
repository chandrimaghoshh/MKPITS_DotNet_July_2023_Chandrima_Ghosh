#include<iostream>
using namespace std;
class employee
{
	public:
		int emp_no;
		string name;
		static string company_Name;
		employee(int emp_no, string name)
		{
			this->emp_no = emp_no;
			this->name = name;
		}
		void display()
		{
			cout<<"Employee No. : "<<emp_no<<endl;
			cout<<"Employee Name : "<<name<<endl;
			cout<<"Company Name : "<<company_Name<<endl;
		}
};
string employee :: company_Name = "Techno Mile";
int main()
{
	employee e1 = employee(12,"Chandrima");
	employee e2 = employee(13,"Akash");
	e1.display();
	e2.display();
	return 0;
}
