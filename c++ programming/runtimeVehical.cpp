#include<iostream>
using namespace std;
class Vehical
{
	public:
		virtual void start()
		{
			cout<<"Start engine :"<<endl;
		}
		virtual void stop()
		{
			cout<<"Stop engine : "<<endl;
			cout<<"------------------------------"<<endl;
		}
};
class Car : public Vehical
{
	public:
		void start()
		{
			cout<<"Car is start"<<endl;
		}
		void stop()
		{
			cout<<"Car is stop"<<endl;
			cout<<"------------------------------"<<endl;
		}
};
class Motorcycle : public Vehical
{
	public:
		void start()
		{
			cout<<"Motocycle is start"<<endl;
		}
		void stop()
		{
			cout<<"Motocycle is stop"<<endl;
			cout<<"------------------------------"<<endl;
		}
};
class Truck : public Vehical
{
	public:
		void start()
		{
			cout<<"Truck is start"<<endl;
		}
		void stop()
		{
			cout<<"Truck is stop"<<endl;
		}
};
int main()
{
	Vehical *V;
	
	Vehical v;
	V = &v;
	V->start();
	V->stop();
	
	Car c;
	V = &c;
	V->start();
	V->stop();
	
	Motorcycle m;
	V = &m;
	V->start();
	V->stop();
	
	Truck t;
	V = &t;
	V->start();
	V->stop();
	return 0;
}
