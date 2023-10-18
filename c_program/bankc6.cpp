#include<iostream>
using namespace std;
class bankaccount
{
	public:
		int accountnumber;
		int bal=1000;
		int amt;
	int depositeamount()
	{
		bal=bal+amt;
		return bal;	
	}
	int withdrawl()
	{
		bal=bal-amt;
		return bal;            
	}
};
int main()
{
    int result;
    bankaccount b1;
    cout<<"Enter accountnumber:"<<endl;
    cin>>b1.accountnumber;
    cout<<"Enter amount:"<<endl;
    cin>>b1.amt;
    result=b1.depositeamount();
    cout<<"depositeamount="<<result<<endl;
    result=b1.withdrawl();
    cout<<"withdrawl="<<result<<endl;
    
    
    	
}
