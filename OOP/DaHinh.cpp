#include <iostream>
using namespace std;
class Shape // Lớp trừu tượng
{
public:
  virtual void draw() = 0; // Hàm thuần ảo
};
class Circle : public Shape
{
public:
  void draw() { cout << "I am a circle" << endl; }
};
class Triangle : public Shape
{
public:
  void draw() { cout << "I am a triangle" << endl; }
};
int main()
{
  Shape *s;
  Triangle t;
  Circle c;
  s = &t;
  s->draw();
  s = &c;
  s->draw();
  system("pause");
}
