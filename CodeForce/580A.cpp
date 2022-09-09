#include <iostream>
using namespace std;
int main()
{
  long a[100000];
  int max=1;
  int count=1;
  long n;
  cin >> n;
  for(long i=0;i<n;i++)
  {
    cin >> a[i];
  }
  for(long i=1;i<n;i++)
  {
    if(a[i]<a[i-1])
    count=1;
    else
    {
      count++;
    }
    if(max<count)
    max=count;

  }
  cout << max;

}