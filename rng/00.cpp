#include <random>
#include <stdint.h>
#include <iostream>
using namespace std;
int main(){
    typedef mt19937 THERNG;
    int sdval;

    THERNG rng;

    rng.seed(sdval);

    uniform_int_distribution<int> dist(0,69);
    int f = dist(rng);
    for(int c = 0; c < 69; c++)
    {cout << dist(rng) << f << endl;}
    cout << "f spew: " << f;
    system("pause");


}


// this engine spews random crap on every call but static on next runs.
