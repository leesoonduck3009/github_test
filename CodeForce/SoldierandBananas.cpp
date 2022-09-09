#include <iostream>
using namespace std;

int main()
{
  int a, b, c;
  cin >> a >> b >> c;
  for (int i = 1; i <= c; i++)
  {

    b = b - i * a;
  }
  if (b < 0)
    cout << abs(b);
  else
  {
    cout << 0;
  }
}