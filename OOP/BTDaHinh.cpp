#include <iostream>
using namespace std;
class A
{
  void XuaTt() { cout << "HELLO Binh. "; };

protected:
  void XuatA() { cout << "Binh A"; };
  static void Xuat4() { cout << 4; };

public:
};
class B : public A
{
protected:
public:
  void Xuat() { cout << "HELLO B"; };
  void XuatBP() { cout << "HELLO BP."; };
};
class C : public B
{
public:
  void Xuat() { this->XuatA(); };
};
int main()
{
 try{
   cout << "abc";
 }
 catch()
}
