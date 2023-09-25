#include<stdio.h>
void main()
{
	int row,col;
	int arr[3][3];
	
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			printf("Enter number:");
			scanf("%d",&arr[row][col]);
		}
		
	}
	
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
		  	printf("arr[%d][%d=[%d]\n",row,col,arr[row][col]);	
		}
		
	}
	
}
