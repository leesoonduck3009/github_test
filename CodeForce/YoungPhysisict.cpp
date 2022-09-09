#include <iostream>
using namespace std;

int main()
{
  int a[100][3];
  int n;
  int tong = 0;
  cin >> n;
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < 3; j++)
    {
      cin >> a[i][j];
    }
  }
  for (int i = 0; i < 3; i++)
  {

    for (int j = 0; j < n; j++)
    {
      tong += a[j][i];
    }
    if (tong != 0)
    {
      cout << "NO";
      return 0;
    }
  }
  cout << "YES";
  return 0;
}