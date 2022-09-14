#include <iostream>
using namespace std;
long SNT(long n, long i = 2)
{
  if (n < 2)
    return 0;
  if (n == 2 || i > n / 2)
    return 1;
  if (n % i == 0)
    return 0;

  return (n, i + 1);
}
void swap(long &a, long &b)
{
  long temp = a;
  a = b;
  b = temp;
}
void sort(long a[], long n)
{
  for (long i = 0; i < n - 1; i++)
  {
    for (long j = i + 1; j < n; j++)
    {
      if (a[i] > a[j])
        swap(a[i], a[j]);
    }
  }
}
int main()
{
  long n;
  cin >> n;
  long a[1000];
  for (long i = 0; i < n; i++)
  {
    cin >> a[i];
  }
  sort(a, n);
  for (long i = 0; i < n; i++)
  {
    if (a[i] == a[i - 1])
      continue;
    if (SNT(a[i]))
      cout << a[i] << " ";
  }
  return 0;
}