#include <string>
#include <iostream>
#include <sstream>
int main(){
    std::string coom(char*);
    char n[10];
    std::cin.getline(n,10);
    std::cout << coom(n) << std::endl;
}

std::string coom(char* ass){
std::ostringstream os;
os << ass;
return os.str();
}