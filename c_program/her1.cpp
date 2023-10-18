#include<iostream>
using namespace std;

class Shape
{
public:
    int x;
    int y;
    void getdata(int a, int b)
    {
        x = a;
        y = b;
    }
};

class Rectangle : public Shape
{
public:
    int crarea(int l, int b)
    {
        int ra;
        ra = l * b;
        return ra;
    }
};

class Triangle : public Shape
{
public:
    float ctarea(int b, int h)
    {
        float ta;
        ta = 0.5f * b * h;
        return ta;
    }
};

int main()
{
    Rectangle r;
    Triangle t;
    int length, breadth, base, height;
    int ra;
    float ta;

    cout << "Enter length and breadth: ";
    cin >> length >> breadth;
    ra = r.crarea(length, breadth);
    cout << "Area of rectangle: " << ra << endl;

    cout << "Enter base and height: ";
    cin >> base >> height;
    ta = t.ctarea(base, height);
    cout << "Area of triangle: " << ta << endl;

    return 0;
}

