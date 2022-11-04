#include <iostream>
#include "GoodsFuncsLib.h"

using namespace std;
int main() {
    GoodsFuncs::GoodsFuncs goods = GoodsFuncs::GoodsFuncs("car", "22/12/2018", 3789, 32, 456950);
    GoodsFuncs::GoodsFuncs goods2 = GoodsFuncs::GoodsFuncs("car", 3789.32, 11);

    GoodsFuncs::GoodsFuncs goodsResult = goods + goods2;
    goodsResult.Display();
    goodsResult = goods - goods2;
    goodsResult.Display();
    goodsResult = goods * 10;
    goodsResult.Display();

    return 0;
}