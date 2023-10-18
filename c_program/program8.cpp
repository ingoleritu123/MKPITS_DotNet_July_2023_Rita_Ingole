#include<iostream>
using namespace std;
int main()
{
	int day_no;
	
	cout<<"Enter a Day_No:";
	cin>>day_no;
	switch(day_no)
	{
		case 1:
			cout<<"\nMonday";
			break;
		case 2:
			cout<<"\nTuesday";
			break;
		case 3:
			cout<<"\nWednesday";
			break;
		case 4:
			cout<<"\nThusday";
			break;
		case 5:
			cout<<"\nFriday";
			break;
		case 6:
			cout<<"\nSaturday";
			break;
		case 7:
			cout<<"\nSunday";
			break;
		default:
			cout<<"\nOpps!! something went wrong please try again!!";
			break;
	}
	
}
