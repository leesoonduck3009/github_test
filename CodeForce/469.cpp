#include <iostream>
using namespace std;
int main()
{
  int a[100];
  int b[100];
  int j;
  int x;
  int an,bn,totalPoint;
  cin >> totalPoint;
  for(int i=0;i<totalPoint;i++)
  {
    a[i]=i+1;
    b[i]=0;
  }
  cin >> an;
  for(int i=0;i<an;i++)
  {
    cin >> x;
    j=0;
    while(j<totalPoint)
      {if(a[j]==x)
        b[j]=1;
        j++;
      }
  }
  cin >> bn;
  for(int i=0;i<bn;i++)
  {
    cin >> x;
    j=0;
    while(j<totalPoint)
      {if(a[j]==x)
        b[j]=1;
        j++;
      }
  }
  for(int i=0;i<totalPoint;i++)
  {
    if(b[i]==0)
    {
      cout << "Oh, my keyboard!";
      return 0;
    }
  }
  cout << "I become the guy.";
  return 0;
}