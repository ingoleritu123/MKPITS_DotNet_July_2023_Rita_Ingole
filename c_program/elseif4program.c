#include<stdio.h>
void main()
{
	char name[50];
	int salary,bonus=0;
	printf("Enter name: ");
	scanf("%s",&name);
	printf("Enter basic salary");
	scanf("%d", salary);
	if(salary>=10000)
	{
		printf("bonus = 5000");
	}
	else if(salary>5000 && salary<10000)
	{
		printf("bonus=2000");
	}
	else
	{
		print("bonus=100");
	}
	printf("employe name:%s",name);
	printf("basic salary:%d",salary);
	printf("bonus:%d",bonus);
}
