#include "Goods.h"
#include <iostream>
#include <string>
#include <stdexcept>
#include <ctime>

using namespace std;
using std::string;

Goods::Goods(string _name, string _registrationDate, double _price, int _amount, int _invoiceNumber) {
    name = _name;
    registrationDate = _registrationDate;
    price = _price;
    amount = _amount;
    invoiceNumber = _invoiceNumber;
}

Goods::Goods(string _name, double _price, int _amount) {
    name = _name;
    registrationDate = "";
    price = _price;
    amount = _amount;
    invoiceNumber = 0;
}

Goods::Goods() {
    name = "";
    registrationDate = "";
    price = 0;
    amount = 0;
    invoiceNumber = 0;
}

void Goods::Read() {
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

void Goods::Display() {
    cout << "Product Name: " << name << endl;
    cout << "Registration Date: " << registrationDate << endl;
    cout << "Price: " << price << endl;
    cout << "Amount: " << amount << endl;
    cout << "Invoice Number: " << invoiceNumber << endl;
}

string Goods::toString() {
    return to_string(price);
}

void Goods::changeAmount(int valueToAdd) {
    this->amount = this->amount + valueToAdd;
}

void Goods::changePrice(double newPrice) {
    this->price = newPrice;
}

double Goods::calculateGoodsCost() {
    return this->price * this->amount;
}

void Goods::checkNames(string name1, string name2) {
    if (name1 != name2) {
        throw invalid_argument( "goods names must be different" );
    }
}

Goods Goods::operator+(Goods goods) {
    Goods tmp;

    checkNames(this->name, goods.name);
    tmp.name = goods.name;
    tmp.amount = this->amount + goods.amount;
    tmp.price = (this->calculateGoodsCost() + goods.calculateGoodsCost()) / tmp.amount;

    return tmp;
}

void Goods::numberMustBeNonNegative(int num, string errorMessage) {
    if (num < 0) {
        throw invalid_argument(errorMessage);
    }
}

Goods Goods::operator*(int n) {
    Goods tmp = Goods(this->name, this->registrationDate, this->price, this->amount, this->invoiceNumber);
    tmp.amount *= n;
    numberMustBeNonNegative(tmp.amount, "goods amount can't be negative");

    return tmp;
}

Goods Goods::operator-(Goods goods) {
    Goods tmp;

    checkNames(this->name, goods.name);
    tmp.name = goods.name;
    tmp.amount = this->amount - goods.amount;
    numberMustBeNonNegative(tmp.amount, "goods amount can't be negative");
    tmp.price = (this->calculateGoodsCost() - goods.calculateGoodsCost()) / tmp.amount;
    numberMustBeNonNegative(tmp.price, "goods price can't be negative");

    return tmp;
}