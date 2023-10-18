#include<stdio.h>
void main()
{
	int day_no;
	
	printf("Enter day_no:");
	scanf("%d",&day_no);
	
	Switch(day_no)
	{
		case1:
			printf("\n Monday");
			break;
		case2:
			printf("\n tuesday");
			break;
	    case3:
			printf("\n wednesday");
			break;
		case4:
			printf("\n thusday ");
			break;
	    case5:
			printf("\n friday");
			break;		
	    case6:
			printf("\n saturday");
			break;		
		case7:
			printf("\n sunday");
			break;	
		default:
		    printf("Oops something went wrong please try again");
			break;			
				
	}
	
}
