#include <iostream>
#include <iomanip>
using namespace std;
double drink(int a[],int n)
{
  double kq=0;

  for(int i=0;i<n;i++)
  {
    kq+=a[i];
  }
  return kq/n;
}
int main()
{
  int a[100];
  int n;
  cin >> n;
  for(int i=0;i<n;i++)
  {
    cin >> a[i];
  }
  cout << setprecision(12)<< drink(a,n);
  return 0;

}