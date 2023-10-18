#include<stdio.h>
void main()
{
	int num ;
	int counter;
	int result=0;
	printf("Enter num");
	scanf("\n%d",&num);
	for(counter=1;counter<=10;counter++)
	{
		result=num*counter;
		printf("\n%d*%d=%d",num,counter,result);
	}
}

