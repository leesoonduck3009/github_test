#include <iostream>
using namespace std;
int main()
{
  int k,l,m,n;
  int count=0;
  long d;
  cin >> k >> l >> m >> n >> d;
  for(int i=1;i<=d;i++)
  {
    if(i%k==0)
    {
      count++;
      continue;
    }
    if(i%m==0)
    {
      count++;
      continue;
    }
    if(i%n==0)
    {
      count++;
      continue;
    }
    if(i%l==0)
    {
      count++;
      continue;
    }
  }
  cout << count;
}