#include<iostream>
using namespace std;
class Ability
{
	protected:
		string abilityname;
		public:
			void getAName(string an)
			{
				abilityname = an;
			}
};
class Equipment
{
	protected:
		string equipitem;
		public:
			void getEI(string ei)
			{
				equipitem = ei;
			}
};
class Character : public Ability, public Equipment
{
	protected:
		string charactername;
		public:
			void getCN(string cn)
			{
				charactername = cn;
			}
			void display()
			{
				cout<<"Character Name : "<<charactername<<endl;
				cout<<"Ability : "<<abilityname<<endl;
				cout<<"Equipment : "<<equipitem<<endl;
			}
};
int main()
{
	Character ch;
	string abi,equip,charac;
	cout<<"Enter Character, Ability, Equipment : ";
	cin>>abi>>equip>>charac;
	ch.getAName(abi);
	ch.getEI(equip);
	ch.getCN(charac);
	ch.display();
	return 0;
}
