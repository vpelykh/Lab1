#include "Rational.h"
#include <iostream>
#include <string>
#include <cstring>  
#include <sstream>

using namespace std;
using std::string;

void Rational::Read()
{
    cout << "Auntie: ";
    cin >> this->a;
    cout << "Mantissa: ";
    cin >> this->b;
}

void Rational::Display()
{
    cout << "Rational: " <<  to_string(this->a) + "," + to_string(this->b) << endl;
}

Rational Rational::operator+(Rational r) {
    return Rational(a * r.b + b * r.a, b * r.b);
}

Rational Rational::operator-(Rational r) {
    return Rational(a * r.b - b * r.a, b * r.b);
}

Rational Rational::operator/(Rational r) {
    return Rational(a * r.b, b * r.a);
}