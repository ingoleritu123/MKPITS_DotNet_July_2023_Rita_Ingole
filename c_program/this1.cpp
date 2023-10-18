#include<iostream>
using namespace std;
class Employee
{
	public:
		int emp_no; 
		string emp_name;
	Employee(int emp_no,string emp_name)
	{
		this->emp_no=emp_no;
		this->emp_name=emp_name;
	}
	void displaydata()
	{
		cout<<"Employee name:"<<emp_name<<endl;
		cout<<"Employee number:"<<emp_no<<endl;
	}
};
int main()
{
	Employee e1(123,"reeta");
	e1.displaydata();
	return 0;
}
