#pragma once

class Pair {
	private: int a; int b;
	public:
		Pair()
		{
			a = 0;
			b = 0;
		}
		Pair(int an, int bn)
		{
			a = an;
			b = bn;
		}
		void Display();
		Pair operator*(Pair p);
		Pair operator-(Pair p);
		bool operator==(Pair p);
		bool operator!=(Pair p);
};