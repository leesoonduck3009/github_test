#include <iostream>
#include <string>
using namespace std;
bool check(string a)
{
  // if(a[0]>'Z')
  // {
    for(int i=1;i<a.size();i++)
    {
      if(a[i]>'Z')
      return 0;
    }
    return 1;
  // }
  // else
  // {
  //   for(int i=1;i<a.size();i++)
  //   {
  //     if(a[i]>'Z')
  //     return 0
  //   }
  // }

}
int main()
{
  string a;
  getline(cin, a);
  if (check(a))
  {
    //a[0] = toupper(a[0]);
    for (int i = 0; i < a.size(); i++)
    {
      if(a[i]>'Z')
      a[i]-=32;
      else
      {
        a[i]+=32;
      }
    }
  }
  cout << a;

}