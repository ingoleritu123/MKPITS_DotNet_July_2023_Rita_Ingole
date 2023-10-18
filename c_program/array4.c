#include<stdio.h>
void main()
{
	int no;
	int i;
	int marks[100];
	printf("Enter number:");
	scanf("%d",&no);
	
	for(i=0;i<no;i++)
	{
		printf("\n Enter marks:");
		scanf("%d",&marks[i]);
	}
	for(i=no-1;i>=0;i--)
	{
		printf("\nmarks=%d",marks[i]);
	}
	
}
