#pragma once
#include <iostream>
using namespace std;
class Triangle
{
private: int x1; int x2; int x3; int y1; int y2; int y3;
public:
	Triangle(int x1n, int y1n, int x2n, int y2n, int x3n, int y3n)
	{
		x1 = x1n;
		y1 = y1n;
		x2 = x2n;
		y2 = y2n;
		x3 = x3n;
		y3 = y3n;
	}
	void Display()
	{
		cout << "x1 = " << x1 << endl;
		cout << "y1 = " << y1 << endl;
		cout << "x2 = " << x2 << endl;
		cout << "y2 = " << y2 << endl;
		cout << "x3 = " << x3 << endl;
		cout << "y3 = " << y3 << endl;
	}
};
