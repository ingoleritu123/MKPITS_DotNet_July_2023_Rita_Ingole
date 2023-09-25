#include<stdio.h>
void main()
{
	int i;
	int sum=0;
	int marks[5];
	printf("-----Marks Calculation-----");
	
	for(i=0;i<5;i++)
	{
		
		printf("\nEnter marks: ");
		scanf("%d",&marks[i]);
	}
	for(i=0;i<=3;i++)
	{
		printf("\nmarks=%d",marks[i]);
		sum=sum+marks[i];
    }  
    printf("\n total marks=%d",sum);
}
