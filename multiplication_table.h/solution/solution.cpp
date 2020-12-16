#include <string>
#include <sstream>
#include <iostream>
int main()  
{
  std::string multi_table(int);
  int n;
  std::cin >> n;

  std::cout << multi_table(n) << "\n" << std::endl;
  
}
std::string multi_table(int number)
{
  std::ostringstream os;
  for (int i = 1; i <= 10; i++) {
    os << i << " * " << number << " = " << i*number << (i<10 ? "\n" : "");
  }
  return os.str();
}



// goal is to return multiplication table for number that is always an integer from 1 to 10.