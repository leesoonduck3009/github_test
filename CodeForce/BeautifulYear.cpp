#include <iostream>
#include <string>
using namespace std;

int check(int year)
{
  int a[100];
  int i = 0;
  while (year != 0)
  {
    a[i] = year % 10;
    i++;
    year /= 10;
  }
  for (int j = 0; j < i; j++)
  {
    for (int k = j + 1; k <= i; k++)
    {
      if (a[j] == a[k])
        return 0;
    }
  }
  return 1;
}
int main()
{
  int year;
  cin >> year;
  int yearafter = year + 1;
  while (!check(yearafter))
  {
    yearafter++;
  }
  cout << yearafter;
}