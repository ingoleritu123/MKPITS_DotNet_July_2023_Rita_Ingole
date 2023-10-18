#include<iostream>
using namespace std;
int main()
{
	int age;
	cout<<"Enter Your Age:";
	cin>>age;
	if(age>18 && age<60)
	{
		cout<<"You are an Adult.";
	}
	else
	{
		cout<<"You are an Old.";
	}
	return 0;
}
