#include<stdio.h>

void main()
 {
    char name[10];
    int age;
    char gender;

    
    printf("Enter name: ");
    fgets(name, sizeof(name), stdin);
    printf("Enter age: ");
    scanf("%d", &age);
    printf("Enter gender (M/F): ");
    scanf(" %c", &gender);


    printf("\nName: %s", name);
    printf("Age: %d\n", age);
    printf("Gender: %c\n", gender);

    
    int isEligible = age >= 18;

    
    if (isEligible) 
	{
        printf("You are eligible to vote.\n");
    } 
	else
	 {
        printf("You are not eligible to vote.\n");
    }

    
    int maleCount = 0, femaleCount = 0, eligibleCount = 0;
    printf("\nGenders and Eligibility Count:\n");
    printf("+---------+-------+-----------+\n");
    printf("| Gender  | Count | Eligible  |\n");
    printf("+---------+-------+-----------+\n");
    if (gender == 'M' || gender == 'm') {
        maleCount++;
        if (isEligible) {
            eligibleCount++;
        }
    } else if (gender == 'F' || gender == 'f') {
        femaleCount++;
        if (isEligible) {
            eligibleCount++;
        }
    }
    printf("|   Male  |   %d   |    %s     |\n", maleCount, (isEligible ? "Yes" : "No"));
    printf("|  Female |   %d   |    %s     |\n", femaleCount, (isEligible ? "Yes" : "No"));
    printf("+---------+-------+-----------+\n");


}
