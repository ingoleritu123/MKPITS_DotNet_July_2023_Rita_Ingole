#include<stdio.h>
void main()
{
	int i;
	int arr1[5];
	int arr2[5];
	
	for(i=0;i<5;i++)
	{
		printf("\n Enter Number:");
		scanf("%d",&arr1[i]);
	}
	for(i=0;i<5;i++)
	{
		arr2[i]=arr1[i];
	}
	printf("\n Element of arr1");
	
	for(i=0;i<5;i++)
	{
		printf("\n%d",arr1[i]);
	}
	printf("\n Elements of arr2");
	for(i=0;i<5;i++)
	{
		printf("\n%d",arr2[i]);
	}
}
