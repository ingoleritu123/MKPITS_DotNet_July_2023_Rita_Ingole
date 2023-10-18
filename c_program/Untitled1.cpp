#include <iostream>
using namespace std;

class BankAccount
{
 public:
    std::string accountNumber;
    double bankBalance;

    // Constructor
    BankAccount(const std::string& accNumber, double initialBalance = 0.0)
        : accountNumber(accNumber), bankBalance(initialBalance) {}

    // Member function to deposit money
    void deposit(double amount) {
        bankBalance += amount;
        std::cout << "Deposited " << amount << " units. New balance: " << bankBalance << std::endl;
    }

    // Member function to withdraw money
    void withdraw(double amount) {
        if (amount <= bankBalance) {
            bankBalance -= amount;
            std::cout << "Withdrew " << amount << " units. New balance: " << bankBalance << std::endl;
        } else {
            std::cout << "Insufficient funds." << std::endl;
        }
    }
};

int main() {
    BankAccount account1("123456", 1000.0);

    account1.deposit(500);
    account1.withdraw(200);
    account1.withdraw(1500);

    return 0;
}
