 
#include <stdio.h>

void main()
 {
    int age;

    printf("Enter your age: ");
    scanf("%d", &age);

    if (age >= 18 && age < 60) {
        printf("You are an adult.\n");
    } else if (age >= 60) {
        printf("You are old.\n");
    } else {
        printf("You are not an adult yet.\n");
    }

