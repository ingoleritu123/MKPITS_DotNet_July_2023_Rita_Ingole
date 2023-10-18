#include<iostream>
using namespace std;
class circle
{
	public:
		int radius;
	float calculatearea()
	{
		float a=3.14f*radius*radius;
		return a;
	}
	float calculatecir()
	{
		float cir=2*3.14f*radius;
		return cir;
	}
};
int main()
{
	float result;
    circle c1;         
	cout<<"Enter value of radius:";
	cin>>c1.radius;
	result=c1.calculatearea();
	cout<<"area of a circle="<<result<<endl;
	result=c1.calculatecir();
	cout<<"circumferance of a circle="<<result;
	
}
