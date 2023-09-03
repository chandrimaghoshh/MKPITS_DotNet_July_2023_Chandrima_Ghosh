#include<iostream>
using namespace std;
class Game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
};
class Tiktakto : public Game
{
	public:
		void start()
		{
			cout<<"Game is start"<<endl;
		}
		void play()
		{
			cout<<"Game is play"<<endl;
		}
		void end()
		{
			cout<<"Game is end"<<endl;
			cout<<"---------------------"<<endl;
		}
};
class Cheess : public Game
{
	public:
		void start()
		{
			cout<<"Game is start"<<endl;
		}
		void play()
		{
			cout<<"Game is play"<<endl;
		}
		void end()
		{
			cout<<"Game is end"<<endl;
		}
	
};
int main()
{
	
	Tiktakto t;
	t.start();
	t.play();
	t.end();
	
	Cheess c;
	c.start();
	c.play();
	c.end();
	return 0;
}
