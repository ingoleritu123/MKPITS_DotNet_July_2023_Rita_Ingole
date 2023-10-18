#include<stdio.h>
void main()
{
	int num1,num2,result;
	char op;
	
	printf("\n+-----+------+\n");
	printf("Enter 1st number: ");
	scanf("%d",&num1);
	
	printf("Enter 2nd number: ");
	scanf("%d",&num2);
	
	printf("Enter Operator(+,-,*,%): ");
	fflush(stdin);
	scanf("%c",&op);
	
	switch(op) 
	{
		case '+':
			result=num1+num2;
			break;
		case '-':
			result=num1-num2;
			break;
		case '*':
			result=num1*num2;
			break;
		case '%':
			result=num1%num2;
			break;
		default:
			printf("invalid op");
			break;
			
	}
	
	
	printf("result=%d",result);
	

}
