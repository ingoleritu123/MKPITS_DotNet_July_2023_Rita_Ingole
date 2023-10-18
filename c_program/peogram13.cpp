#include<iostream>
using namespace std;
int main()
{
	int counter;
	int num;
	int result;
	cout<<"Enter a num";
	cin>>num;
	for(counter=1;counter<=10;counter++)
	{
		result=num*counter;
		cout<<num<<counter<<result;
	}
}
	
