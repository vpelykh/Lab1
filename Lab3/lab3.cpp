#include <iostream>
#include "Goods.h"

using namespace std;

int main() {
    Goods goods = Goods("car", "22/12/2018", 3789, 12, 456950);
    goods.Display();
    goods.changePrice(78.21);
    cout << goods.toString() << endl;
    goods.changeAmount(-2);
    cout << goods.calculateGoodsCost() << endl;

    goods = Goods("car", 3789.32, 12);
    goods.Display();

    goods = Goods();
    goods.Display();

    return 0;
}
