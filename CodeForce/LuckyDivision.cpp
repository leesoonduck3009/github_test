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
  }
  return 1;
}

int main()
{
  string str;
  int a[] = {4, 7, 44, 47, 74, 77, 444, 447, 474, 477, 744, 747, 774, 777};
  getline(cin, str);

  if (check(str))
    cout << "YES";
  else
  {
    for (int i = 0; i < 8 + 2 + 4; i++)
      if (stoi(str) % a[i] == 0 || stoi(str) % a[i] == 0)
      {
        cout << "YES";
        return 0;
      }
    cout << "NO";
  }
  return 0;
}
