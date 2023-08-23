#include<iostream>
using namespace std;
class Engine
{
	private:
		int power;
	public:
		void getpower(int po)
		{
			power = po;
		}
		void start()
		{
			cout<<"Engine is started"<<endl;
		}
		void stop()
		{
			cout<<"Engine is stoped"<<endl;
		}
		void displaypo()
		{
			cout<<"Engine Power : "<<power<<endl;
		}
		
};
class Vehical
{
	private:
		string brand;
	public:
		void getbrand(string br)
		{
			brand = br;
		}
		void accelerator()
		{
			cout<<"Accelerate the car"<<endl;
		}
		void brake()
		{
			cout<<"Break the car"<<endl;
		}
		void display()
		{
			cout<<"Brand : "<<brand<<endl;
		}
};
class car : public Engine, public Vehical
{
	public:
		void drive()
		{
			cout<<"Car is driving "<<endl;
		}
		void park()
		{
			cout<<"Car is parked"<<endl;
		}
};
int main()
{
	car c1;
	c1.getbrand("Audi");
	c1.display();
	c1.getpower(1400);
	c1.displaypo();
	c1.start();
	c1.drive();
	c1.accelerator();
	c1.brake();
	c1.park();
	c1.stop();
	return 0;
	
}
