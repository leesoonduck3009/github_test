#include <iostream>
#include <string.h>
using namespace std;
int main()
{
  char a[1000], b[1000];
  cin.getline(a, 1000);
  cin.getline(b, 1000);
  int count = 0;
  int tong2 = 0;

  for (int i = 0; i < strlen(a); i++)
  {
    a[i] = toupper(a[i]);
    b[i] = toupper(b[i]);
  }
  for(int i=0;i<strlen(a);i++)
  {
    if(a[i] > b[i])
      {
        cout << 1;
        return 0;
      }
    else if(a[i]<b[i])
      {
        cout << -1;
        return 0;
      }
  }
  cout << 0;
  return 0;
}