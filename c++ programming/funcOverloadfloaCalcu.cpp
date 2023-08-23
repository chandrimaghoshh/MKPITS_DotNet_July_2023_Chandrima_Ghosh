#include<iostream>
using namespace std;
class calculate
{
	public:
		int add(int n1, int n2)
		{
			return n1+n2;
		}
		float add(float n1, float n2)
		{
			return n1+n2;
		}
};
int main()
{
	calculate c;
	int n1,n2;
	float n1f,n2f;
	cout<<"Enter 2 integer num : ";
	cin>>n1>>n2;
	
	cout<<"Enter 2 float num :";
	cin>>n1f>>n2f;
	cout<<"Addition of 2 integer num : "<<c.add(n1,n2)<<endl;
	cout<<"Addition of 2 float num : "<<c.add(n1f,n2f);
	return 0;
}
