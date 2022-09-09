#include <iostream>
#include <string>
using namespace std;
int main()
{
  string str;

  getline(cin, str);
  int count;
  int max = 0;
  for (int i = 0; i < str.size() - 1; i++)
  {
    count = 1;
    for (int j = i + 1; j < str.size(); j++)
    {
      if (str[i] != str[j])
        break;
      count++;
    }
    if (count >= 7)
    {
      cout << "YES";
      return 0;
    }
  }

  cout << "NO";

  return 0;
}