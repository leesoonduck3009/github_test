#include <iostream>
using namespace std;
int check(int a[][2],int n)
{
  int count=0;
  for(int i=0;i<n;i++)
  {
    if(a[i][1]-a[i][0]>=2)
    count++;
  }
  return count;
}
int main()
{
  int a[100][2];
  int n;
  cin >> n;
  for(int i=0;i<n;i++)
  {
    cin >> a[i][0] >> a[i][1];
  }
  cout << check(a,n);
  return 0;
}