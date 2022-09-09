#include <iostream>
using namespace std;
int main()
{
  long a[4];
  int count=0;
  int count1;
  int n=4;
  for(int i=0;i<4;i++)
  {
    cin >> a[i];
  }
  for(int i=0;i<n-1;i++)
  {
    for(int j=i+1;j<n;j++)
    {
      if(a[i]==a[j] && j==n-1)
      {
        count++;
        n--;
        break;
      }
      if(a[i]==a[j])
      {
          count++;
        for(int t=j;t<n;t++)
        a[t]=a[t+1];
        j--;
        n--;
      }
    }
  }
  cout << count;
}