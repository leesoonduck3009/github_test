#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main()
{
  string a;
  getline(cin, a);
  for (int i = 0; i < a.size() - 1; i++)
  {
    if (a[i] >= '0' && a[i] <= '9')
      for (int j = i + 1; j < a.size(); j++)
        if (a[j] >= '0' && a[j] <= '9')
          if (a[i] > a[j])
            swap(a[i], a[j]);
  }
  cout << a;
}