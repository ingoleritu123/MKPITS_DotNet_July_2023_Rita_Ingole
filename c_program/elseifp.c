#include<stdio.h>
void main()
{
	char name[50];
	int salary,bonus=0;
	printf("Enter name: ");
	scanf("%s",&name);
	printf("Enter basic salary: ");
	scanf("%d",&salary);
	if(salary>=10000)
	{
		bonus = 5000;
	}
	else if(salary>=5000 && salary<10000)
	{
		bonus=2000;
	}
	else
	{
		bonus=100;
	}
	printf("\n+----Details with bonus----+\n");
	printf("employe name:%s\n",name);
	printf("basic salary:%d\n",salary);
	printf("bonus:%d\n",bonus);
}
