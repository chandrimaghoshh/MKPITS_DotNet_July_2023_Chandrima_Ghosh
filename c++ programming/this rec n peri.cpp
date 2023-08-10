#include<iostream>
using namespace std;
class rectangle
{
	public:
		int length;
		int breadth;
		rectangle()
		{
			this->length = length;
			this->breadth
			 = breadth;	
		}
		float calculatearea()
		{
		float a=length*breadth;
		return a;
		}
		float calculateperi()
		{	
		float peri=2*(length+breadth);
		return peri;
		}
};
int main()
{
	int result,length,breadth;
	rectangle r1;
	cout<<"Enter length & breadth :";
	cin>>r1.length>>r1.breadth;
	result=r1.calculatearea();
	cout<<"Area of rectangle = "<<result<<endl;
	result=r1.calculateperi();
	cout<<"Area of perimeter = "<<result;
	void display();
	return 0;
}
