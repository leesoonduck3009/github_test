#include <iostream>
#include <string>
using namespace std;
int main()
{
  string str, tmp = "hello";
  char i[100];
  int k = 0;
  getline(cin, str);
  for (int i = 0; i < str.size(); i++)
  {
    if (str[i] == tmp[k])
    {
      k++;
    }
    if (k == 5)
    {
      cout << "YES";
      return 0;
    }
  }

  cout << "NO";
  return 0;
}