#include <iostream>
#include <string>
#include <string.h>
using namespace std;

int main()
{
  string a;
  string b = ".";
  getline(cin, a);
  for (int i = 0; i < a.length(); i++)
  {
    if (a[i] >= 'a' && a[i] <= 'z')
    {
      if (a[i] == 'a' || a[i] == 'o' || a[i] == 'y' || a[i] == 'e' || a[i] == 'u' || a[i] == 'i')
      {
        a.erase(a.begin() + i);
        i--;
      }
      else
      {
        a.insert(a.begin() + i, '.');
        i++;
      }
    }
    else if (a[i] >= 'A' && a[i] <= 'Z')
    {
      if (a[i] == 'A' || a[i] == 'O' || a[i] == 'Y' || a[i] == 'E' || a[i] == 'U' || a[i] == 'I')
      {
        a.erase(a.begin() + i);
        i--;
      }
      else
      {
        a.insert(a.begin() + i, '.');
        i++;
        a[i] = towlower(a[i]);
      }
    }
  }
  cout << a;
}