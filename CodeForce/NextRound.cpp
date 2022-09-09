#include <iostream>
using namespace std;

int main()
{
  int k, n;
  int a[100];
  int count = 0;
  cin >> n;
  cin >> k;
  for (int i = 0; i < n; i++)
  {
    cin >> a[i];
  }
  for (int i = 0; i < n; i++)
  {
    if (a[i] >= a[k - 1] && a[i] > 0)
      count++;
  }
  cout << count;
  return 0;
}