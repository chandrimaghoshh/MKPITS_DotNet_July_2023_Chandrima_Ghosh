#include <iostream>
using namespace std;
class Shape
{
    public:
    virtual void area()
    {
        cout<<"Draw method of shape class"<<endl;
    }
};
class Circle : public Shape
{
    public:
    void area()
    {
        float r=5,res;
        res=3.14f*r*r;
        cout<<"Area of circle : "<<res<<endl;
    }
};
class Rectangle : public Shape
{
    public:
    void area()
    {
        int l=5,b=2,res;
        res=l*b;
        cout<<"Area of rectangle : "<<res<<endl;
	}
};
int main()
{
    Shape *S;
    Shape s;
    S=&s;
    S->area();
    
    Circle c;
    S=&c;
    S->area();
    
    Rectangle r;
    S=&r;
    S->area();
    return 0;
    
}
