#include <stdio.h>

int main()
 {
    int num;
	int i; 
	int oddNumber = 1;
	int sum = 0;
    printf("+-------------------------------------+");
    printf("\nEnter the number:");
    scanf("%d", &num);
    
    printf("+-------------------------------------+");
    printf("\nThe first %d odd natural numbers are:\n",num);
    for (i = 1; i <=num; i++)
	{
        printf("%d ", oddNumber);
        sum += oddNumber;
        oddNumber += 2;
    }
    printf("\n+-------------------------------------+");
    printf("\nSum of the first %d odd natural numbers = %d\n", num, sum);

    return 0;
}
