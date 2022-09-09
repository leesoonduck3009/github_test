#include <iostream>
#include <string>
using namespace std;
void swap(char &a, char &b)
{
  char tmp = a;
  a = b;
  b = tmp;
}
int main()
{
  string str;
  int n, x;
  cin >> x;
  cin >> n;
  cin.ignore();
  getline(cin, str);
  for (int i = 0; i < n; i++)
  {
    for (int i = 0; i < str.size() - 1; i++)
    {
      if (str[i] == 'B' && str[i + 1] == 'G')
      {
        swap(str[i], str[i + 1]);
        i++;
      }
    }
  }
  cout << str;
}