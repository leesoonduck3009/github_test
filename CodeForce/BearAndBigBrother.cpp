#include <iostream>
using namespace std;

int main()
{
  int x, y;
  int count=0;
  cin >> x;
  cin >> y;
  while(x<=y)
  {
    x=x*3;
    y=y*2;
    count++;
  }
  cout << count;
  return 0;
}