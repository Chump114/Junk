#include <iostream>
#include <math.h>
using namespace std;
int main(){
bool isPrime(int);
cout << isPrime(69);
}

bool isPrime(int num) {
  // your code here..
  num = abs(num) % 2;
 if (num == 0){
   return false;
 }
  else{
    return true;
  }  
}