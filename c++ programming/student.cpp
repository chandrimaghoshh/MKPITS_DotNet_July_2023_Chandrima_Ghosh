#include<iostream>
using namespace std;
class student
{
	public:
		int rollno;
		string name;
		string course;
	void getData()
	{
		cout<<"Rollno "<<"Name "<<"Course ";
		cin>>rollno>>name>>course;
	}		
	void displayData()
	{
		cout<<"Rollno : "<<rollno<<endl;
		cout<<"Name : "<<name<<endl;
		cout<<"Course : "<<course<<endl;
	}
};
int main()
{
	student stud1,stud2;
	cout<<"student 1: "<<endl;
	stud1.getData();
	stud1.displayData();
	cout<<"student 2: "<<endl;
	stud2.getData();
	stud2.displayData();
}
