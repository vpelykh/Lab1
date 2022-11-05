#include "Pair.h"
#include <iostream>
#include <string>
using namespace std;

void Pair::Display()
{
	cout << "Pair: " << to_string(this->a) + "," + to_string(this->b) << endl;
}

Pair Pair::operator-(Pair p) {
	return Pair(a - p.a, b - p.b);
}

Pair Pair::operator*(Pair p) {
	return Pair(a * p.a, b * p.b);
}

bool Pair::operator==(Pair p) {
	return a == p.a && b == p.b;
}

bool Pair::operator!=(Pair p) {
	return a != p.a || b != p.b;
}

