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
	s1.name = "Chandrima";
	s1.city = "Kolkata";
	s1.rno = 123;
	s1.marks = 100;
	cout<<s1.name<<endl<<s1.city<<endl<<s1.rno<<endl<<s1.marks;
	return 0;
	
}

