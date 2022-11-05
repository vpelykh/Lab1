#include "Pair.h"
#include <iostream>
using namespace std;

class Rational : public Pair
{
private: int a; int b;
public:
    Rational()
    {
        a = 0;
        b = 0;
    }
    Rational(int an, int bn)
    {
        a = an;
        b = bn;
    }
    void Read();
    void Display();
    string toString();
    Rational operator/(Rational r);
    Rational operator+(Rational r);
    Rational operator-(Rational r);
};

