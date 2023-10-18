#include<iostream>
using namespace std;
class Employee
{
	public:
		string emp_name;
		int emp_no;
	Employee()
	{
		emp_no =123;
		emp_name ="reeta";
	}
	void displaydata()
	{
		cout<<"employee name:"<<emp_name<<endl;
		cout<<"employee number:"<<emp_no<<endl;
	}
		
};
int main()
{
	Employee emp1;
	emp1.displaydata();
	return 0;
	
	
	
}
