#include <iostream>
using namespace std;
int main()
{
  long long n, k;
  long long mid;
  cin >> n;
  cin >> k;
  if (n % 2 == 1)
  {
    mid = n / 2 + 1;
  }
  else
  {
    mid = n / 2;
  }
  if (k <= mid)
  {
    cout << 2 * k - 1;
  }
  else
    cout << 2 * (k - mid);
  system("pause");
}