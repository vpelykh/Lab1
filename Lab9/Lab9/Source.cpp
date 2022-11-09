#include<iostream>

using namespace std;

class base {

public:

	virtual void myname() {
		cout << "This is class Base" << endl;

	}

	~base() { cout << "Destruktor base" << endl; }

};

class DerA : public base {

public:

	void myname() { cout << "This is class DerA" << endl; }

	~DerA() { cout << "destruktor DerA" << endl; }

};

class DerB :public base {

public:

	void myname() {

		cout << "this is class DerB" << endl;
	}

	~DerB() { cout << "destruktor DerB" << endl; }

};

int main() {

	base obj1;

	base* p;

	DerA obj2;

	DerB obj3;

	p = &obj1;

	p->myname();

	p = &obj2;

	p->myname();

	p = &obj3;

	p->myname();

	return 0;

}