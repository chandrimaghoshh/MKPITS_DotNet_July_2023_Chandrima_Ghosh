#include<iostream>
using namespace std;
class Animals
{
	public:
		virtual void sound()
		{
			cout<<"Sounds of animals"<<endl;
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
	Dog d;
	Cat c;
	Cow co;
	
	A = &a;
	A->sound();
	
	A = &d;
	A->sound();
	
	A = &c;
	A->sound();
	
	A = &co;
	A->sound();
	return 0;
}
