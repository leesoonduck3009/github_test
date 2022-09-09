#include <iostream>
#include <string>
using namespace std;
int check(string a)
{
  int counta = 0;
  int countb = 0;
  for (int i = 0; i < a.size(); i++)
  {
    if (i > 0)
    {
      if (a[i] == 'a' && a[i - 1] == 'b')
      {
        if (countb < 2)
          return 0;
        countb = 0;
      }
      if (a[i] == 'b' && a[i - 1] == 'a')
      {
        if (counta < 2)
          return 0;
        counta = 0;
      }
    }
    if (a[i] == 'a')
      counta++;
    if (a[i] == 'b')
      countb++;
  }
  if(countb==1||counta==1)
  return 0;
  return 1;
}
int main()
{
  string a[1000];
  int n;
  cin >> n;
  cin.ignore();
  for (int i = 0; i < n; i++)
    getline(cin, a[i]);
  for (int i = 0; i < n; i++)
  {
    if (check(a[i]) == 1)
      cout << "YES\n";
    else
      cout << "NO\n";
  }
  return 0;
}