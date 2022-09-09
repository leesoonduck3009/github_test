#include <iostream>
#include <string>
using namespace std;
int main()
{
  string a;
  int n;
  int flag = 0;
  int flag1 = 0;
  cin >> n;
  cin.ignore();
  getline(cin,a);
  for(int i=0;i<n;i++)
  {
    if(a[i]>='A'&& a[i]<='Z')
      flag=1;


  }
  for(int i=0;i<n-1;i++)
  {
    for(int j=i+1;j<n;j++)
    {
      if(a[i]==a[j])
      {
        flag1=1;
        return 0;
      }
    }
  }
  return 0;

}