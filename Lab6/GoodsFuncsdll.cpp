#include <utility>
#include <limits.h>
#include "GoodsFuncsdll.h"
#include <iostream>
#include <string>
#include <stdexcept>
#include <ctime>

using namespace std;
using std::string;
namespace GoodsFuncs {

    GoodsFuncs::GoodsFuncs(string _name, string _registrationDate, double _price, int _amount, int _invoiceNumber) {
        name = _name;
        registrationDate = _registrationDate;
        price = _price;
        amount = _amount;
        invoiceNumber = _invoiceNumber;
    }

    GoodsFuncs::GoodsFuncs(string _name, double _price, int _amount) {
        name = _name;
        registrationDate = "";
        price = _price;
        amount = _amount;
        invoiceNumber = 0;
    }

    GoodsFuncs::GoodsFuncs() {
        name = "";
        registrationDate = "";
        price = 0;
        amount = 0;
        invoiceNumber = 0;
    }

    void GoodsFuncs::Read() {
        cout << "Product Name:";
        cin >> this->name;
        cout << "Registration Date:";
        cin >> this->registrationDate;
        cout << "Price:";
        cin >> this->price;
        cout << "Amount:";
        cin >> this->amount;
        cout << "Invoice Number:";
        cin >> this->invoiceNumber;
    }

    void GoodsFuncs::Display() {
        cout << "Product Name: " << name << endl;
        cout << "Registration Date: " << registrationDate << endl;
        cout << "Price: " << price << endl;
        cout << "Amount: " << amount << endl;
        cout << "Invoice Number: " << invoiceNumber << endl;
    }

    string GoodsFuncs::toString() {
        return to_string(price);
    }

    void GoodsFuncs::changeAmount(int valueToAdd) {
        this->amount = this->amount + valueToAdd;
    }

    void GoodsFuncs::changePrice(double newPrice) {
        this->price = newPrice;
    }

    double GoodsFuncs::calculateGoodsCost() {
        return this->price * this->amount;
    }

    void GoodsFuncs::checkNames(string name1, string name2) {
        if (name1 != name2) {
            throw invalid_argument("goods names must be different");
        }
    }

    void GoodsFuncs::numberMustBeNonNegative(int num, string errorMessage) {
        if (num < 0) {
            throw invalid_argument(errorMessage);
        }
    }
}