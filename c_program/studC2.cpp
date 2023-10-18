#include<iostream>
using namespace std;
class Student
{
	public:
		int roll_no;
		string Name;
		string Course;
	void getData()
	{
		cout<<"Enter your Name:";
		cin>>Name;
		cout<<"Enter your roll_no:";
		cin>>roll_no;
		cout<<"Enter your Course Name:";
		cin>>Course;
	}
	
	void displayData()
	{
		cout<<"                       \n";
		cout<<"---Student Details---\n";
		cout<<"Name:"<<Name<<endl;
		cout<<"roll_no:"<<roll_no<<endl;
		cout<<"Course Name:"<<Course<<endl;
			
	}
};
int main()
{
	Student stud1,stud2;
	cout<<"student 1"<<endl;
	stud1.getData();
	stud1.displayData();
	cout<<"student 2"<<endl;
	stud2.getData();
	stud2.displayData();
	return 0;
}
