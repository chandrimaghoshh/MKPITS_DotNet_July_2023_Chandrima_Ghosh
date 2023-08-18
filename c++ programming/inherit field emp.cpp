#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string city;
};
class employee : public person
{
	public:
		int salary;
		int id;
};
int main()
{
	employee e1;
	cout<<"Enter Name City Salary Id : ";
	cin>>e1.name>>e1.city>>e1.salary>>e1.id;
	cout<<e1.name<<endl<<e1.city<<endl<<e1.salary<<endl<<e1.id;
	return 0;	
}
