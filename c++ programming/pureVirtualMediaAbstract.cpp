#include<iostream>
using namespace std;
class Media_Player
{
	public:
		virtual void play()=0;
		virtual void pause()=0;
		virtual void stop()=0;
};
class Audio_Player : public Media_Player
{
	public:
		void play()
		{
			cout<<"Audio is play"<<endl;
		}
		void pause()
		{
			cout<<"Audio is pause"<<endl;
		}
		void stop()
		{
			cout<<"Audio is stop"<<endl;
			cout<<"----------------------------"<<endl;
		}
};
class Video_Player : public Media_Player
{
	public:
		void play()
		{
			cout<<"Video is play"<<endl;
		}
		void pause()
		{
			cout<<"Video is pause"<<endl;
		}
		void stop()
		{
			cout<<"Video is stop"<<endl;
		}
};
int main()
{
	Audio_Player a;
	a.play();
	a.pause();
	a.stop();
	
	Video_Player v;
	v.play();
	v.pause();
	v.stop();
	return 0;
}
