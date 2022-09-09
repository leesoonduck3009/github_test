#include <iostream>
using namespace std;
int main()
{
  int a[100000];
  long n;
  cin >> n;
  long count = 1;
  for (int i = 0; i < n; i++)
  {
    cin >> a[i];
  }
  if(n==1)
  {
    cout << 1;
    return 0;
  }
  for (int i = 1; i < n; i++)
  {
    if (a[i - 1] % 10 != a[i] % 10)
      count++;
  }
  cout << count;
  return 0;
}