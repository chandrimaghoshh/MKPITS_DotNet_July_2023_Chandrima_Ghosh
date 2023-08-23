#include<iostream>
using namespace std;
class rectangle
{
	public:
	int length;
	int breadth;
	int calculatearea()
	{
		int a=length*breadth;
		return a;
	}
	int calculateperi()
	{
		int peri=2*(length+breadth);
		return peri;
	}
};
int main()
{
	int result;
	rectangle r1;
	cout<<"Enter length & breadth :";
	cin>>r1.length>>r1.breadth;
	result=r1.calculatearea();
	cout<<"Area of rectangle = "<<result<<endl;
	result = r1.calculateperi();
	cout<<"Area of perimeter = "<<result;
	return 0;
}
