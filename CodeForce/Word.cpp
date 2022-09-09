#include <iostream>
#include <string>
#include <string.h>
using namespace std;

int main()
{
  string str;
  int countA = 0;
  int counta = 0;
  getline(cin, str);
  for (int i = 0; i < str.size(); i++)
  {
    if (str[i] >= 'A' && str[i] <= 'Z')
      countA++;
    if (str[i] >= 'a' && str[i] <= 'z')
      counta++;
  }
  if (countA > counta)
  {
    for (int i = 0; i < str.size(); i++)
    {
      str[i] = toupper(str[i]);
    }
  }
  else
  {
    for (int i = 0; i < str.size(); i++)
    {
      str[i] = tolower(str[i]);
    }
  }
  cout << str;
  return 0;
}