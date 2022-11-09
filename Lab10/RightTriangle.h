#pragma once
#include "Triangle.h"
#include <math.h>
class RightTriangle :
    public Triangle
{
private: int x1; int x2; int x3; int y1; int y2; int y3; double a; double b; double c;
public:
    RightTriangle(int x1n, int y1n, int x2n, int y2n, int x3n, int y3n) : Triangle(x1n, y1n, x2n, y2n, x3n, y3n)
    {
        x1 = x1n;
        y1 = y1n;
        x2 = x2n;
        y2 = y2n;
        x3 = x3n;
        y3 = y3n;
        a = 0;
        b = 0;
        c = 0;
    };
    void CountSides()
    {
        a = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
        b = sqrt(pow(x3 - x2, 2) + pow(y3 - y3, 2));
        c = sqrt(pow(x3 - x1, 2) + pow(y3 - y1, 2));
    }
    void DisplaySides()
    {
        cout << "a = " << a << endl;
        cout << "b = " << b << endl;
        cout << "c = " << c << endl;
    }
    double CountInscribedCircle()
    {
        double r = (a + b - c) / 2;
        return r;
    }
    double CountDescribedCircle()
    {
        double R = c / 2;
        return R;
    }
};

//CountSides рахує довжину сторін, DisplaySides виводить значення, CountInscribedCircle рахує радіус вписаного кола,
//CountDescribedCircle рахує радіус описаного кола
#pragma once
