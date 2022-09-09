#include <iostream>
#include <algorithm>
using namespace std;
int Max(int a[],int n,int& idx)
{
  int max=a[0];
  idx=0;
  for(int i=1;i<n;i++)
  {
    if(max<a[i])
      {max=a[i];
      idx=i;
      }
  }
  return max;
}
int Min(int a[],int n,int& idx)
{
  int min=a[0];
  idx=0;
  for(int i=1;i<n;i++)
  {
    if(min>=a[i])
     { min=a[i];
     idx=i;
     }
  }
  return min;
}
int main()
{
  int n, a[1000];
  int i,j,min,max;
  int count=0;
  cin >> n;
  for(int k=0;k<n;k++)
  cin >> a[k];
  min=Min(a,n,i);
  while(a[n-1]!=min)
  {
    swap(a[i],a[i+1]);
    i++;
    count++;
  }
  max=Max(a,n,j);
  while(a[0]!=max)
  {
    swap(a[j],a[j-1]);
    j--;
    count++;
  }
  cout << count;
}