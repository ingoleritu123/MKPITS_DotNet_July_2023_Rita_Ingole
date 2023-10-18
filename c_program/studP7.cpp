#include <iostream>
using namespace std;

class Student
{
	public:
	string name;
    string classname;
    int roll_no;
    float marks;
    char grade;
    void studentdata()
    {
    	cout<<"Enter your Name:";
		cin>>name;
		cout<<"Enter your classname:";
		cin>>classname;
		cout<<"Enter your roll_no:";
		cin>>roll_no;
		cout<<"Enter your marks:";
		cin>>marks;
        calculateGrade();
    }
	void calculateGrade() 
	{
        if (marks >= 90) {
            grade = 'A';
        } else if (marks >= 80) {
            grade = 'B';
        } else if (marks >= 70) {
            grade = 'C';
        } else if (marks >= 60) {
            grade = 'D';
        } else {
            grade = 'F';
        }
    }
    void displayStudentdata() 
	{
		cout<<"                        \n";
		cout<<"-----Student Details-----\n";
        cout << "Name: " << name << endl;
        cout << "Class: " << classname<< endl;
        cout << "Roll_No:"<<roll_no<<endl;
        cout << "Marks: " << marks << endl;
        cout << "Grade: " << grade << endl;
    }
};
int main() 
{
	Student stud1;
	cout<<"student 1"<<endl;
	stud1.studentdata();
	stud1.displayStudentdata();
}


