#include<iostream>
using namespace std;
class car
{
	public:
		string make;
		string model;
		int year;
	void startEngine()
	{
		cout<<"Engine started"<<endl;
	}
	void brake()
	{
		cout<<"Break applied";
	}
};
int main()
{

	car c1;
	c1.make="Maruti";
	c1.model="suv";
	c1.year=2022;
	cout<<"Make : "<<c1.make<<endl;
	cout<<"Model : "<<c1.model<<endl;
	cout<<"Year : "<<c1.year<<endl;
	c1.startEngine();
	c1.brake();
	return 0;
}
