#include <iostream>
using namespace std;
int main()
{
  int n;
  int a[100];
  int b[100];
  cin >> n;
  for(int i=0;i<n;i++)
  {
    cin >> a[i];
  }
  for(int i=0;i<n;i++)
  {
    b[a[i]-1]=i+1;
  }
  for(int i=0;i<n;i++)
  {
    cout << b[i] << " ";
  }
}