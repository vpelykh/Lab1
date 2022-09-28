#ifndef LAB1_GOODS_H
#define LAB1_GOODS_H
#include <iostream>
#include <string>
using std::string;

class Goods {
private:
    string name, registrationDate;
    int amount, invoiceNumber;
    double price;
    static void numberMustBeNonNegative(int num, string errorMessage);
    static void checkNames(string name1, string name2);
public:
    Goods(string name, string registrationDate, double price, int amount, int invoiceNumber);
    Goods(string name, double price, int amount);
    Goods();
    void Read();
    void Display();
    string toString();
    void changePrice(double newPrice);
    void changeAmount(int valueToAdd);
    double calculateGoodsCost();
    Goods operator+(Goods goods);
    Goods operator-(Goods goods);
    Goods operator*(int n);
};


#endif //LAB1_GOODS_H
