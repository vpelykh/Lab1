#pragma once
#include <iostream>
#include<math.h>
#include<string.h>
using namespace std;
class Polyndrom
{
public:
	static bool isPolyndrom(string line)
	{
		for (int i = 0; i < line.length() / 2; i++) {
			if (line[i] != line[line.length() - i - 1]) {
				return false;
			}
		}
		return true;
	}

	//��� ������������ ���������
	static void validateInput(string& s)
	{
		bool isValid = s.size() == 0;
		for (const char c : s) {
			if (isspace(c))
				isValid = true;
		}
		if (isValid) {
			cout << "Input must contais a line without spaces" << endl;
		}		
	}
	
	//� ������������� throw()
	static void validateInput2(string& s)
	{
		bool isValid = s.size() == 0;
		for (const char c : s) {
			if (isspace(c))
				isValid = true;
		}
		if (isValid) {
			throw "Input must contais a line without spaces";
		}		
	}
	
	//� ���������� ������������� � ��������� ����������� �����������
	static void validateInput3(string& s)
	{
		bool isValid = s.size() == 0;
		for (const char c : s) {
			if (isspace(c))
				isValid = true;
		}
		if (isValid) {
			throw exception("Input must contais a line without spaces");
		}		
	}
	//������������ �� ������� ����������� �����������
	
	static void validateInput4(string& s)
	{
		bool isValid = s.size() == 0;
		for (const char c : s) {
			if (isspace(c))
				isValid = true;
		}
		if (isValid) {
			throw runtime_error("Input must contais a line without spaces");
		}
	}
};