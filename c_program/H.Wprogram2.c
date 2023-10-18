#include <stdio.h>

void main()
 {
    int age;
    char name[50];
    char gender;
    char eligibility[10];
     printf("\n+---Please input following information---+\n");
    

    printf("Enter your name: ");
    scanf("%s", name);
    
     printf("Enter your age: ");
    scanf("%d", &age);


    printf("Enter your gender (Male/Female): ");
    scanf(" %c", &gender);

    

    printf("\n+--- User Information ---+\n");
    printf("Name: %s\n", name);
    printf("Age: %d\n", age);
    printf("Gender: %c\n", gender);
    printf("\n+---eligibility for voting---+\n");
    
    
    
    if (age>=18) 
	{
        printf("You are eligible to vote.\n");
    } 
	else
	 {
        printf("You are not eligible to vote.\n");
    }
    
    
    printf("\nGenders and Eligibility Count:\n");
    printf("+---------+-------+-----------+\n");
    printf("| Gender  | Count | Eligible  |\n");
    printf("+---------+-------+-----------+\n");

    
}
