#include "Goods.h"
#include <iostream>
#include <string>

using namespace std;
using std::string;

Goods Goods::Init(string name, string registrationDate, double price, int amount, int invoiceNumber) {
    Goods goodsInstance;
    goodsInstance.name = name;
    goodsInstance.registrationDate = registrationDate;
    goodsInstance.price = price;
    goodsInstance.amount = amount;
    goodsInstance.invoiceNumber = invoiceNumber;

    return goodsInstance;
}

Goods Goods::Init(string name, string registrationDate, int price, int amount, int invoiceNumber) {
    return Init(name, registrationDate, (double) price, amount, invoiceNumber);
}

Goods Goods::Init(string name, double price, int amount) {
    return Init(name, "", price, amount, 0);
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