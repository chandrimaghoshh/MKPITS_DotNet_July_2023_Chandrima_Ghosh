#include<iostream>
using namespace std;
class employee
{
	public:
	int empno;//instance variable
	string empname;
	employee(int empno, string empname)
	{
		this -> empno = empno;
		this -> empname = empname;
	}
	void display()
	{
		cout<<empno<<empname;
	}
};
	int main()
	{
		employee e1(123, " Chandrima");
		e1.display();
		return 0;
	}
