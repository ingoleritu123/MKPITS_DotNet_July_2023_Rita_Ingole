#include<iostream>
using namespace std;
int main()
{
	int counter;
	int sum=0;
	
	while(counter<=5)
	{
		sum=counter+sum;
		counter=counter+1;
	}
	cout<<"sum="<<sum;
}
