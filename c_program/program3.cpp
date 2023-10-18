#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0;
	char op;
	cout<<"Enter 1 number:";
	cin >> n1;
	cout<<"\nenter 2 number:";
	cin>>n2;
	cout<<"\nEnter operator:";
	cin>>op;
	if (op=='+')
	{
		sum=n1+n2;
	}
	else if (op=='-')
	{
		sum=n1-n2;
	}
	else if (op=='*')
	{
		sum=n1*n2;
	}
	else if (op=='%')
	{
		sum=n1%n2;
	}
	cout<<"\nsum="<<sum;
	return 0;
}
