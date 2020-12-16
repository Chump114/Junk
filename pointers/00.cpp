#include <iostream>
int main(){
    
    int* piss = new int;
    std::cout << piss << std::endl;
    delete piss;
    piss = new int(69);
    std::cout << piss << std::endl;
    
}

/*

delete operator: deletes|deallocate a value from the original memory address in the heap.
useful for freeing up garbage. 

*/