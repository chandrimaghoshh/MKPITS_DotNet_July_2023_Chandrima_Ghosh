#include<iostream>
using namespace std;
class Ability
{
	private:
		string abilityname;
		public:
			void getAN(string an)
			{
				abilityname = an;
			}
			void display()
			{
				cout<<"Ability Name :"<<abilityname<<endl;	
			}
};
class Equipment
{
	private:
		string equipitem;
		public:
			void getEI(string ei)
			{
				equipitem = ei;
			}
			void display()
			{
				cout<<"Equipment Name :"<<equipitem<<endl;
			}
};
class Character : public Ability, public Equipment
{
	private:
		string charactername;
		public:
			void getCN(string cn, string an, string ei)
			{
				charactername=cn;
				getAN(an);
				getEI(ei);
			}
			void display()
			{
				cout<<"Character Name : "<<charactername<<endl;
				Ability::display();
				Equipment::display();
			}
};
int main()
{
	Character ch;
	ch.getCN("Alian","Attack","Gun");
	ch.display();
	return 0;
}
