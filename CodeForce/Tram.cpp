#include <iostream>
using namespace std;
int main()
{
  int a[1000][2];
  int max = 0;
  int tong = 0;
  int n;
  cin >> n;
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < 2; j++)
      cin >> a[i][j];
  }
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < 2; j++)
    {
      if (j == 0)
        tong -= a[i][j];
      else
      {
        tong += a[i][j];
      }
      if (max < tong)
        max = tong;
    }
  }
  cout << max;
  return 0;
}