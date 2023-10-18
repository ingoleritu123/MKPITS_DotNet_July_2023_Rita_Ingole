#include <stdio.h>

int main()
 {
    char customerName[50], productName[50];
    float price, totalAmount, discount = 0;
    int quantity;

    // Input customer name
    printf("Enter customer name: ");
    fgets(customerName, sizeof(customerName), stdin);

    // Input product name
    printf("Enter product name: ");
    fgets(productName, sizeof(productName), stdin);

    // Input price 
    printf("Enter price: ");
    scanf("%f", &price);
    
     //input quantity
    printf("Enter quantity: ");
    scanf("%d", &quantity);

    // Calculate totalamount
    totalAmount = price * discount;

    // Calculate discount  totalamount
    if (totalAmount > 1000)
	 {
        totalamount*0.4; 
    } 
	else if (totalAmount > 5000)
	 {
        total*0.25;
    }
	 else
     {
        discount*0.1; 
    }

    
    
    // Output 
    printf("\n----TOTAL BILL----\n");
    printf("+----------+----------+");
    printf("\nCustomer: %s", customerName);
    printf("Product: %s", productName);
    printf("Total Amount: %.2f\n", totalAmount);
    printf("Discount: %.2f%%\n", discount * 100);
    printf("+----------+----------+");
    return 0;
}

