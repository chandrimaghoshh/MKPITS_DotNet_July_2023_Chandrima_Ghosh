#include<iostream>
using namespace std;
class classA
{
	public:
		void display()
		{
			cout<<"Display from class A "<<endl;
		}
};
class classB
{
	public:
		void display()
		{
			cout<<"Display from class B";
		}
};
class classC : public classA, public classB
{
	public:
		void displayC()
		{
			classA::display();
			classB::display();
		}
};
int main()
{
	classC c1;
	c1.displayC();
	return 0;
}
