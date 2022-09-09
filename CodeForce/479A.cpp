#include <iostream>
using namespace std;

int main()
{
  int a,b,c,kq[6],max=0;
  cin >> a;
  cin >> b;
  cin >> c;
  kq[0]= (a+b) *c;
  kq[1]=a+b*c;
  kq[2]=a*b*c;
  kq[3]=a*b+c;
  kq[4]=a+b+c;
  kq[5]=a*(b+c);
  for(int i=0;i<6;i++)
  {
    if(max<kq[i])
    max=kq[i];
  }
  cout << max;
  return 0;
}