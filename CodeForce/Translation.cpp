#include <iostream>
#include <string>
using namespace std;

int main()
{
  string str, str1;
  int k;
  getline(cin, str);
  getline(cin, str1);
  k = str.size() - 1;
  for (int i = 0; i < str.size(); i++)
  {
    if (str[i] != str1[k])
    {
      cout << "NO";
      return 0;
    }
    k--;
  }
  cout << "YES";
  return 0;
}