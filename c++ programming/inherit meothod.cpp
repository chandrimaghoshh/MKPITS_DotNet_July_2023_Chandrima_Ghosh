#include<iostream>
using namespace std;
class animals
{
	public:
		void eat()
		{
			cout<<"Dog eating "<<endl;
		}
};
class dog : public animals
{
	public:
		void bark()
		{
			cout<<"Dog barking "<<endl;
		}
};
int main()
{
	dog d1;
	d1.eat();
	d1.bark();
	return 0;	
}

