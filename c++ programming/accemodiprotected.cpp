#include<iostream>
using namespace std;
class person
{
	private:
		string name;
};
class student : private person
{
	private:
	void getdata(string n)
	{
		name = n;
	}
	void display()
	{
		cout<<"Name = "<<name;
	}	
};
int main()
{
	student s1;
	s1.getdata("Chandrima");
	s1.display();
	return 0; 
}
