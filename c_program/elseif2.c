//start
#include<stdio.h>
int main()
{
	int num;
	//accept num
	printf("Enter a number: ");
	scanf("%d",&num);
	//check statment
	if(num==0)
	{
		//if num is equal tozero
		printf("number is zero.");
	}
	else if(num<0)
	{
		//elseif num is less than zero
		printf("number is negavtive.");
	}
	else
	{
		//else 
		printf("number is positive.");
	}
}
