#include <iostream>
#include "Triangle.h"
#include "RightTriangle.h"
using namespace std;

int main()
{
    Triangle one(3, 2, 5, 3, 7, 4);
    one.Display();
    RightTriangle two(2, 5, 2, 1, 5, 1);
    two.Display();
    two.CountSides();
    two.DisplaySides();
    cout << "Radius of the inscribed circle " << two.CountInscribedCircle();
    cout << "Radius of the described circle " << two.CountDescribedCircle();
}
