#include <iostream>
#include<math.h>
#include"Header1.h"
#include<string>
using namespace std;


int main()
{
	string line;
	cout << "Input a line: ";
	getline(cin, line);
	Polyndrom::validateInput(line);
	
	try
	{
		Polyndrom::validateInput2(line);
	}
	catch (const char* err)
	{
		cout << "Error! Something went wrong..." << endl;
	}
	try
	{
		Polyndrom::validateInput3(line);
	}
	catch (const exception& err)
	{
		cout << "Error! " << err.what() << endl;
	}
	try
	{
		Polyndrom::validateInput4(line);
	}
	catch (const runtime_error err)
	{
		cout << "Runtime error " << err.what() << endl;
	}
	catch (const overflow_error err)
	{
		cout << "Overflow error " << err.what() << endl;
	}

	cout << "Line is " << (Polyndrom::isPolyndrom(line) ? "" : "not ") << "a polyndrom" << endl;
}