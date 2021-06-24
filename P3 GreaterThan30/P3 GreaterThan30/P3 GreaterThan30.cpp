#include <iostream>
using namespace std;
bool biggerThan30(int userint ,int userint2 )
{
    int sum;
    int comparevalue = 30;
    sum = userint + userint2;
    if (sum > comparevalue)
    {
        cout << "True";
    }
    else
    {
        cout << "False";
    }
    return " ";
}
int main()
{
    int userint;
    int userint2;
    cout << "Enter the first number: \n";
    cin >> userint;
    cout << "Enter the second number: \n";
    cin >> userint2;
    cout << biggerThan30(userint,userint2);
    
}



