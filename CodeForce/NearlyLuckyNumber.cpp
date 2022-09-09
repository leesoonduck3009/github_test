#include <iostream>
#include <string>
using namespace std;
int check(string str)
{
  int flag4 = 0;
  int flag7 = 0;
  for (int i = 0; i < str.size(); i++)
  {
    if (str[i] != '4' && str[i] != '7')
      return 0;
    if (str[i] == 4)
      flag4 = 1;
    else if (str[i] == 7)
      flag7 = 1;
  }
  if (flag4 == 0 || flag7 == 0)
    return 0;
  return 1;
}
int main()
{
  string str;
  int count = 0;
  int flag2 = 0;
  getline(cin, str);
  if (check(str))
    cout << "YES";
  else
  {
    for (int i = 0; i < str.size(); i++)
    {
      if (str[i] == '4' || str[i] == '7')
        count++;
    }
    if (count == 7 || count == 4)
      cout << "YES";
    else
      cout << "NO";
  }
  return 0;
}