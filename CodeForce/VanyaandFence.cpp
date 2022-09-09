#include <iostream>
using namespace std;
int main()
{
  int a;
  int n;
  int height;
  int width = 0;
  cin >> n;
  cin >> height;
  for (int i = 0; i < n; i++)
  {
    cin >> a;
    if (a > height)
    {
      width += 2;
    }
    else if (a <= height)
    {
      width += 1;
    }
  }
  cout << width;
}