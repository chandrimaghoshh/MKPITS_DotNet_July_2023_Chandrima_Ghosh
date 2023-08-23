#include<iostream>
using namespace std;
class cicle
{
	public:
		int radius;
		float calculatearea()
		{
			float a=3.14f*radius*radius;
			return a;
		}
		float calculatecirc()
		{
			float circ=2*3.14f*radius;
			return circ;
		}
};

int main()
{
	float result;
	cicle c1;
	cout<<"Enter radius : ";
	cin>>c1.radius;
	result=c1.calculatearea();
	cout<<"Area = "<<result<<endl;
	result=c1.calculatecirc();
	cout<<"Circ = "<<result;
}
