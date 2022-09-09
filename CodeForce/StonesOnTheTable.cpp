#include <iostream>
#include <string>
using namespace std;

int main()
{
  int n;
  int j;
  int count = 0;
  cin >> n;
  string str;
  cin.ignore();
  getline(cin, str);
  for (int i = 0; i < str.size() - 1; i++)
  {
    j = i + 1;
    if (str[i] == str[j])
      count++;
  }
  cout << count;
}