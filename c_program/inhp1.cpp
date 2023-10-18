#include<iostream>
using namespace std;
class persone
{
	public:
		string name;
		string city;
};
class Student:public person
{
	public:
		int rno;
		int marks;
};
int main()
{
	student s1;
	s1.name="reeta";
	s1.city="nagpur";
	s1.rno=21;
	s1.marks=90;
	cout<<s1.name<<s1.city<<s1.rno<<s1.marks;
	return 0;
}
