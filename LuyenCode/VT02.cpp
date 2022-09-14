#include <iostream>
using namespace std;
void swap(int &a, int &b)
{
  int temp = a;
  a = b;
  b = temp;
}
void sort(int a[], int n)
{
  for (int i = 0; i < n - 1; i++)
  {
    for (int j = i + 1; j < n; j++)
    {
      if (a[i] < a[j])
        swap(a[i], a[j]);
    }
  }
}
int MAX2nd(int a[], int n)
{
  int max = a[0];
  for (int i = 1; i < n; i++)
  {
    if (a[i] < max)
      return a[i];
  }
  return -1;
}
int main()
{
  int a[100];
  int n;
  cin >> n;
  for (int i = 0; i < n; i++)
  {
    cin >> a[i];
  }
  sort(a, n);
  if (MAX2nd(a, n) == -1)
    cout << "NOT FOUND";
  else
    cout << MAX2nd(a, n);
}