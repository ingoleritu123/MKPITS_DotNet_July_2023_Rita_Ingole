#include<stdio.h>
void main()
{
	int month;
	
	printf("Enter a month(1-10): ");
	scanf("%d",&month);
	
	swich(month)
	{
		case 1:
			printf("January has 31 days");
			break;
		case 2:
			printf("Feb has 28 days");
			break:
		case 3:
			printf("march has 31 days");
			break;
		case 4:
			printf("april has 30 days");
			break;
		case 5:
			printf("may has 31 days");
			break;
		case 6:
			printf("jun has 30 days");
			break;
		case 7:
			printf("july has 31 days ");
			break;
		case 8:
			printf("august has 30 days");
			break;
		case 9:
			printf("september has 31 days");
			break;
		case 10:
			printf("octomber has 30 days");
			break;
		case 11:
			printf("november has 31 days");
			break;
		case 12:
			printf("december has 30 days");
			break;
			
			
	}
}
