#include <iostream>
using namespace std;
int main()
{
  int n;
  int count = 0;
  cin >> n;
  do
  {
    count++;
    n = n - 5;
  } while (n > 0);
  cout << count;
  return 0;
}