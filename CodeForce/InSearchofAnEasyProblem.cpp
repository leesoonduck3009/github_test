#include <iostream>
using namespace std;
int main()
{
  int a[100];
  int n;
  cin >> n;
  for (int i = 0; i < n; i++)
  {
    cin >> a[i];
  }
  for (int i = 0; i < n; i++)
  {
    if (a[i] == 1)
    {
      cout << "HARD";
      return 0;
    }
  }
  cout << "EASY";
  return 0;
}