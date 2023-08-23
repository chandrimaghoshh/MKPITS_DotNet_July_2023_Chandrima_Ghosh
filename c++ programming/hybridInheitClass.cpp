#include<iostream>
using namespace std;
class classA
{
	protected:
		int n1;
		public:
			void getn1(int n)
			{
				n1 = n;
			}
};
class classB : public classA
{
	protected:
		int n2;
		public:
			void getn2(int n)
			{
				n2 = n;
			}
};
class classC
{
	protected:
		int n3;
		public:
			void getn3(int n)
			{
				n3 = n;
			}
};
class classD : public classB, public classC
{
	 	public:
	 		int multiply()
			 {
			 	int mul = n1*n2*n3;
			 	return mul;
			 }	
};
int main()
{
	classD c1;
	int num1,num2,num3,res;
	cout<<"Enter 3 number: ";
	cin>>num1>>num2>>num3;
	c1.getn1(num1);
	c1.getn2(num2);
	c1.getn3(num3);
	res=c1.multiply();
	cout<<"Multiply = "<<res;
	return 0;	
}
