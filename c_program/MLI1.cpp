#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string add;
		int mo_no;
};
class Employee:public person
{
	public:
		int salary;
		int emp_no;
};
class ParttimeEmployee:public Employee
{
	public:
		int no_of_emp;
};
int main()
{
	Employee e1;
	e1.name="reeta";
	e1.mo_no=9579286231;
	e1.emp_no=21;
	e1.salary=50000;
	cout<<"Employee details:"<<endl;
	cout<<e1.name<<e1.mo_no<<e1.emp_no<<e1.salary<<endl;
	ParttimeEmployee p1;
	p1.name="anurag";
	p1.mo_no=8657976945;
	p1.no_of_emp=22;
	p1.salary=50000;
	cout<<"Parttime Employee details:"<<endl;
	cout<<p1.name<<p1.mo_no<<p1.no_of_emp<<p1.salary<<endl;
	return 0;
	
}
