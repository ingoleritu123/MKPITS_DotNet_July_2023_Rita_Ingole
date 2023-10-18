#include<iostream>
using namespace std;
class Employee
{
	//constructor
	Employee()
	{
		cout<<"constructor called"<<endl;
	}
	//dristroctor
	~Employee()
	{
		cout<<"distroctor called"<<endl;
	}
};
int main()
{
	Employee e1;
	Empolyee e2;
	return 0;
}
