#include<iostream>
using namespace std;
class employee
{
	public:
		string emp_name;
	    int emp_no;
	employee(int eno,string ename)
	{
		emp_no = eno;
	    emp_name = ename;
	}
	void displaydata()
	{
		cout<<"Employee name\n"<<emp_name<<endl;
		cout<<"Employee number\n"<<emp_no<<endl;
	}
		
};
int main()
{
	string ename;
	int eno;
	cout<<"Enter eno:";
	cin>>eno;
	cout<<"Enter ename:";
	cin>>ename;
    employee emp1(12,"reeta");
	emp1.displaydata();
	return 0;

}

