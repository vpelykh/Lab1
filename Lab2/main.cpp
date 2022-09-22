#include <iostream>
#include "Goods.h"

using namespace std;

int main() {
    Goods goods;
    goods = goods.Init("car", "22/12/2018", 3789, 12, 456950);
    goods.Display();
    goods.changePrice(78.21);
    cout << goods.toString() << endl;

    goods.Read();
    goods.Display();
    goods.changeAmount(-2);
    cout << goods.calculateGoodsCost();

    return 0;
}
