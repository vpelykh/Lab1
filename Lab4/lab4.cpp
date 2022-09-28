#include <iostream>
#include "Goods.h"

using namespace std;

int main() {
    Goods goods = Goods("car", "22/12/2018", 3789, 32, 456950);
    Goods goods2 = Goods("car", 3789.32, 11);

    Goods goodsResult = goods + goods2;
    goodsResult.Display();
    goodsResult = goods - goods2;
    goodsResult.Display();
    goodsResult = goods * 10;
    goodsResult.Display();

    return 0;
}
