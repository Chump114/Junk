#include<iostream>
#include<ios>
#include<limits>
using namespace std;
int main() {
   int x;
   char str[80];
   cout << "Enter a number and a string:\n";
   cin >> x;
   cin.ignore(numeric_limits<streamsize>::max(), '\n');
   cin.getline(str,80); //take a string
   cout << "You have entered:\n";
   cout << x << endl;
   cout << str << endl;
}

// works the same way without all the fancy parameters and library

