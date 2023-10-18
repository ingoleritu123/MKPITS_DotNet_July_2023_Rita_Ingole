#include<stdio.h>
void main()
{
	char name[50];
	char designation;
	int salary;
	
	
	printf("\n+---------+---------+\n");
	printf("Enter employee name: ");
	scanf("%s",&name);
	
	printf("\n+---------+---------+\n");

	printf("Enter designation(m,c,p):");
	fflush(stdin);
	scanf("%c",&designation);
    
    
    switch(designation)
    {
    	case 'm':
    		salary=50000;
    		break;
    	case 'c':
    		salary=20000;
    		break;
    	case 'p':
    		salary=10000;
    		break;
    	default:
    		printf("Oops something went wrong");
    		break;
	}
	printf("\n+---------+---------+\n");
	printf("\n+----Employee Detail----+\n");
	printf("\nemployee name:%s",name);
	printf("\nsalary:%d",salary);
	
	
}
