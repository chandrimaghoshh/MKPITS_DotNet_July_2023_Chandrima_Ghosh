#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string city;
};
class student : public person
{
	public:
		int rno;
		int marks;
};
int main()
{
	student s1;
	cout<<"Enter name city rno marks : ";
	cin>>s1.name>>s1.city>>s1.rno>>s1.marks;
	cout<<s1.name<<endl<<s1.city<<endl<<s1.rno<<endl<<s1.marks;
	return 0;
}

