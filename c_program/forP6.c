#include<stdio.h>
void main()
{
	int num;
	int i;
	int cube;
	
	printf("Enter a num : ");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		cube=i*i*i;
		printf("\n%d cube is %d",i,cube);
	}
}

