#include <iostream>
#include <iomanip>
using namespace std;
int main()
{
  long a[1000];
  double TBC = 0;
  double countle = 0;
  int n;
  cin >> n;
  for (int i = 0; i < n; i++)
  {
    cin >> a[i];
  }
  for (int i = 0; i < n; i++)
  {
    if (a[i] % 2 == 1 || a[i] % 2 == -1)
    {
      TBC += (double)a[i];
      countle += 1;
    }
  }
  if (countle == 0)
  {
    cout << "0.0000";
    return 0;
  }
  cout.precision(4);
  cout << fixed << TBC / countle;
}