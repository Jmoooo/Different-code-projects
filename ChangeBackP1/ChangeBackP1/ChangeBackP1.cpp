// ChangeBackP1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    float amountdue;
    float amountgiven;
    float changedue;
    int DollarsConversion;
    int Change;
    int Dollars;
    int Hundreds = 0;
    int Fifties = 0;
    int Twenties = 0;
    int Tens = 0;
    int Fives = 0;
    int Ones = 0;
    int CentsConversion;
    int Cents;
    int Quarters = 0;
    int Dimes = 0;
    int Nickels = 0;
    int Pennies = 0;
    std::cout << "What is the amount due: $";
    cin >> amountdue;
    cout << "What is the amount given: $";
    cin >> amountgiven;
    changedue = amountgiven - amountdue;
    cout << "They will get $" << changedue << " back. \n";
    DollarsConversion = changedue * 100;
    Hundreds = DollarsConversion / 10000;
    Change = DollarsConversion % 10000;
    Fifties = Change / 5000;
    Change %= 5000;
    Twenties = Change / 2000;
    Change %= 2000;
    Tens = Change / 1000;
    Change %= 1000;
    Fives = Change / 500;
    Change %= 500;
    Ones = Change / 100;
    Change %= 100;
    Dollars = changedue;
    CentsConversion = changedue * 1000;
    Dollars *= 1000;
    Cents = CentsConversion - Dollars;
    Quarters = Cents / 250;
    Change = Cents % 250;
    Dimes = Change / 100;
    Change %= 100;
    Nickels = Change / 50;
    Change %= 50;
    Pennies = Change / 10;
    Change %= 10;
    cout << "\nNumber of Hundred Dollar Bills: " << Hundreds;
    cout << "\nNumber of Fifty Dollar Bills: " << Fifties;
    cout << "\nNumber of Twenty Dollar Bills: " << Twenties;
    cout << "\nNumber of Ten Dollar Bills: " << Tens;
    cout << "\nNumber of Five Dollar Bills: " << Fives;
    cout << "\nNumber of One Dollar Bills: " << Ones;
    cout << "\nNumber of Quarters: " << Quarters;
    cout << "\nNumber of Dimes: " << Dimes;
    cout << "\nNumber of Nickels: " << Nickels;
    cout << "\nNumber of Pennies: " << Pennies;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
