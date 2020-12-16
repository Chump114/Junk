#include <stdlib.h>
#include <iostream>
#include <ctime>
int main(){
    srand (time(NULL));

    int i = rand() % 70;
    for(int x = 0; x < i; x++)
    {std::cout << i << std::endl;}
    system("pause");
}

// this engine spews static crap on every call but different on each run 