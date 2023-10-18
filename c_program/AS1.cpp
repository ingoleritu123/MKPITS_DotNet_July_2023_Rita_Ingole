#include<iostream>
using namespace std;
class student
{
	private:
		int r_no;
	public:
		void displaydata()
		{
			cout<<"r_no = "<<r_no;
		}
		void setdata(int r)
		{
			r_no = r;
		}
		
};
int main()
{
	student s1;
	int rn;
	cout<<"Enter r_no:";
	cin>>rn;
	s1.setdata(rn);
	s1.displaydata();
}
