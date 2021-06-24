// P3 E2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    int quit = 0;
    double inputnum;
    double addingnum = 0;
    double totalnumsentered = 0;
    double averagenums;
    double largestnum=-9999999999999999;
    double smallestnum=9999999999999999;
    std::cout << "Enter your first number:\n";
    cin >> inputnum;
    while (inputnum != quit)
    {
        if (inputnum>largestnum)
        {
            largestnum = inputnum;
        }
        else
        {
            largestnum = largestnum;
        }
        if (inputnum < smallestnum)
        {
            smallestnum = inputnum;
        }
        else
        {
            smallestnum = smallestnum;
        }
        totalnumsentered += 1;
        addingnum += inputnum;
        //cout <<"The number you entered was " << inputnum << " and the sum of all numbers added so far is " << addingnum << "\n";
        cout << "Enter another number or enter 0 to quit: \n";
        cin >> inputnum;
    }
    averagenums = addingnum / totalnumsentered;
    cout << "The sum of all numbers entered is " << addingnum << "\n";
    cout << "and the total numbers entered was " << totalnumsentered << "\n";
    cout << "with an average of " << averagenums << "\n";
    cout << "and the largest number entered was " << largestnum << "\n";
    cout << "and the smallest number entered was " << smallestnum << "\n";
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
