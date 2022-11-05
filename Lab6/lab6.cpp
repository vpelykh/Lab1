#include <iostream>
#include "GoodsFuncsdll.h"

using namespace std;
int main() {
    GoodsFuncs::GoodsFuncs goods("car", "22/12/2018", 3789, 32, 456950);

    goods.Display();
    goods.changeAmount(3);
    goods.Display();

    return 0;
}