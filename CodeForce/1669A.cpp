#include <iostream>
using namespace std;
int main()
{
  int a[10000];
  int n;
  cin >> n;
  for(int i=0;i<n;i++)
  {
    cin >> a[i];
  }
  for(int i=0;i<n;i++)
  {
    if(a[i]<=1399)
    cout << "Division 4";
    else if(a[i]<=1599&&a[i]>=1400)
    cout << "Division 3";

    else if(a[i]>=1600&&a[i]<=1899)
    cout << "Division 2";
    else
    cout << "Division 1";
    cout << endl;
  }
}