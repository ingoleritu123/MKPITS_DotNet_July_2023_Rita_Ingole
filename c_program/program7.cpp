#include<iostream>
using namespace std;
int main()
{
	int num;
	cout<<"Enter a Number:";
	cin>>num;
	if(num>1)
	{
		cout<<"Entered Number is Positive.";
	}
	else if (num<0)
	{
		cout<<"Entered Number is negative.";
	}
	else if (num==0)
	{
		cout<<"Entered Number is zero";
	}
	
}
