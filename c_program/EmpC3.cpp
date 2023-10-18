#include<iostream>
using namespace std;
class Employee
{
	public:
		string Employee_Name;
		string Designation;
		int Salary;
	void getdata()
	{
		cout<<"Enter Employee_Name:";
		cin>>Employee_Name;
		cout<<"Enter your Designation:";
		cin>>Designation;
		cout<<"Enter your Salary:";
		cin>>Salary;
	}
	void displaydata()
	{
		cout<<"                    \n";
		cout<<"---Employee Details---";
		cout<<"Employee_Name\n"<<Employee_Name<<endl;
		cout<<"Designation"<<Designation<<endl;
		cout<<"Salary"<<Salary<<endl;
		
	}
};
int main()
{
	Employee Emp1,Emp2;
	cout<<"Employee 1\n";
	Emp1.getdata();
	Emp1.displaydata();
	cout<<"Employee 2\n";
	Emp2.getdata();
	Emp2.displaydata();
	
}
