#include<iostream>
using namespace std;
class student
{
	public:
		string name;
		int clas;
		int rollno;
		void getStudent_Details()
		{
			cout<<"Name- "<<"Class- "<<"Rollno- ";
			cin>>name>>clas>>rollno;
		}
		void displayStudent_Details()
		{
			cout<<"Name : "<<name<<endl;
			cout<<"Class : "<<clas<<endl;
			cout<<"Rollno : "<<rollno<<endl;
		}
		float calculategrade()
		{
			float m1,m2,m3,per;
			cout<<"Enter 3 subj marks : ";
			cin>>m1>>m2>>m3;
			per=(m1+m2+m3)/300*100;
			cout<<"percentage : "<<per<<endl;
			if(per>=75)
			{
				cout<<"Grade is distinction"<<endl;
			}
			else if(per>=60)
			{
				cout<<"Grade is first"<<endl;
			}
			else if(per>=40)
			{
				cout<<"Grade is second"<<endl;
			}
			else
			{
				cout<<"fail"<<endl;
			}
			return per;
		}
};
int main()
{
	student stud;
	stud.getStudent_Details();
	stud.displayStudent_Details();
	stud.calculategrade();
	return 0;
}

