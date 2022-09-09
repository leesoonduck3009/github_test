#include <iostream>
#include <string>
using namespace std;
int main()
{
  string a;
  getline(cin, a);
  char b[100];
  b[0] = a[0];
  int t = 1;
  int flag = 0;
  for (int i = 1; i < a.size(); i++)
  {
    flag = 0;
    for (int j = 0; j < t; j++)
    {
      if (b[j] == a[i])
        flag = 1;
    }
    if (flag != 1)
    {

      b[t] = a[i];
      t++;
    }
  }
  if (t % 2 == 0)
    cout << "CHAT WITH HER!";
  else
    cout << "IGNORE HIM!";

  return 0;
}