#include <iostream>
#include <string>
#include <string.h>
using namespace std;
bool check(string str)
{
  string temp;

  for(int i=0;i<str.length()-5;i++)
  {
    temp=str.substr(i,i+5);
    if(temp=="WUBWUB")
    return 1;
  }

  return 0;
}
void check1(string& str)
{
    string
    for(int i=0;i<str.length()-2;i++)
    {
      if("WUB"==str.substr(i,i+2))
      {
        str.replace(i,i+2," ");
      }
    }

    for(int i=0;i<str.length()-5;i++)
    {
      if("WUBWUB"==str.substr(i,i+5))
      {
        str.replace(i,i+5," ");
      }
    }

}
int main()
{
  string a;
  cin >> a;
  check1(a);
  cout << a;
}