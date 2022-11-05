#pragma once
#ifdef MATHFUNCSDLL_EXPORTS
#define MATHFUNCSDLL_API __declspec(dllexport)
#else
#define MATHFUNCSDLL_API __declspec(dllimport)
#endif
#include <utility>
#include <iostream>
#include <string>
using std::string;

namespace GoodsFuncs {
    class MATHFUNCSDLL_API GoodsFuncs {
    private:
        string name, registrationDate;
        int amount, invoiceNumber;
        double price;
        static void numberMustBeNonNegative(int num, string errorMessage);
        static void checkNames(string name1, string name2);
    public:
        GoodsFuncs(string name, string registrationDate, double price, int amount, int invoiceNumber);
        GoodsFuncs(string name, double price, int amount);
        GoodsFuncs();
        void Read();
        void Display();
        string toString();
        void changePrice(double newPrice);
        void changeAmount(int valueToAdd);
        double calculateGoodsCost();
    };
}

