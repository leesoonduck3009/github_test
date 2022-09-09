#include <iostream>
#include <string>
#include <string.h>
using namespace std;
void plus1(char a, char b)
{
  if(a=='0'&& b=='0')
  cout << 0;
  else if(a=='1'&& b=='1')
  cout << 0;
  else
  cout  << 1;
}
int main()
{
  string a;
  string b;
  getline(cin,a);
  getline(cin,b);
  for(int i=0;i<a.size();i++)
  {
    plus1(a[i],b[i]);
  }
  return 0;
}
