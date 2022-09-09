#include <iostream>
#include <string>
using namespace std;
int main()
{
  int x = 0;
  string str;
  int n;
  cin >> n;
  cin.ignore();
  for (int i = 0; i < n; i++)
  {
    getline(cin, str);
    switch (str[0])
    {
    case '+':
      ++x;
      break;
    case '-':
      --x;
      break;
    case 'X':
    {
      if (str[2] == '+')
        x++;
      else if (str[2] == '-')
        x--;
      break;
    }
    } 
  }
  cout << x;
}