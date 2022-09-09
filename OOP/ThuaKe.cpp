#include <iostream>
#include <math.h>
using namespace std;
class A
{
  public:
  virtual void xuat()
  {
    cout << "A";
  }
};
class B: public  A
{
  public:
  void xuat()
  {
    cout<< "B";
  }
};
class C: public B
{
  public:
  void xuat()
  {
    B:: xuat();
    cout << "C";
  }
};
int main()
{

  A* temp;
  temp=new C;
  temp->xuat();

  return 0;
}