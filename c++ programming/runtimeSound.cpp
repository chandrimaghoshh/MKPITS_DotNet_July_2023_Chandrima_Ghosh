#include<iostream>
using namespace std;
class Animals
{
	public:
		virtual void sound()
		{
			cout<<"Sounds of Animals"<<endl;
			cout<<"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"<<endl;
		}
};
class Dog : public Animals
{
	public:
		void sound()
		{
			cout<<"Dog sound : Wooh-Wooh"<<endl;
		}
};
class Cat : public Animals
{
	public:
		void sound()
		{
			cout<<"Cat sound : Meow-Meow"<<endl;
		}
};
class Cow : public Animals
{
	public:
		void sound()
		{
			cout<<"Cow sound : Moo-Moo"<<endl;
		}
};
int main()
{
	Animals *A;
	
	Animals a;
	A = &a;
	A->sound();
	
	Dog d;
	A = &d;
	A->sound();
	
	Cat c;
	A = &c;
	A->sound();
	
	Cow co;
	A = &co;
	A->sound();
	return 0;
}
