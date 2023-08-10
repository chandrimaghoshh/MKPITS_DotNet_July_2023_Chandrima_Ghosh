#include<iostream>
using namespace std;
class circle
{
	public:
		float radius;
		circle()
		{
			radius=0;
		}
		circle(float radius)
		{
			radius = radius;
		}
		float calculatearea()
		{
			float a = 3.14f*radius*radius;
			return a;
		}
		float calculatecirc()
		{
			float circ = 2*3.14f*radius;
			return circ;
		}
};
int main()
{
	float result;
	int radius;
	circle c1;
	cout<<"Enter radius : ";
	cin>>c1.radius;
	result=c1.calculatearea();
	cout<<"Area of circle = "<<result<<endl;
	result=c1.calculatecirc();
	cout<<"Circ of circle = "<<result;
}

