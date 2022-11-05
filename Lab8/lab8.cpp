#include <iostream>
#include "Pair.h"
#include "Rational.h"
using namespace std;

int main() {
	Pair p1(10, 4);
	Pair p2(2, 3);
	Pair p = p1 - p2;
	p.Display();

	Rational r1(2, 3);
	Rational r2(12, 3);
	Rational r3 = r2 + r1;
	r3.Display();
}
