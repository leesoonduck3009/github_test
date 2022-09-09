#include <iostream>
#include <string>
using namespace std;
void kq(string a, long &str1, long &str2)
{
  int kq1 = 0;
  int kq2 = 0;
  if (a.size() == 1)
    str2 = long(a[0]) - long('a') + 1;
  else if (a.size() % 2 == 0)
    for (int i = 0; i < a.size(); i++)
      str1 += long(a[i]) - long('a') + 1;
  else if (a.size() % 2 == 1)
  {
    for (int i = 1; i < a.size(); i++)
      kq1 += long(a[i]) - long('a') + 1;
    for (int i = a.size() - 2; i >= 0; i--)
      kq2 += long(a[i]) - long('a') + 1;
    if (kq1 > kq2)
    {
      str1 = kq1;
      str2 = long(a[0]) - long('a') + 1;
    }
    if (kq1 <= kq2)
    {
      str1 = kq2;
      str2 = long(a[a.size() - 1]) - long('a') + 1;
    }
  }
}
int main()
{
  long n;
  long count1;
  long count2;
  string a[50000];
  cin >> n;
  cin.ignore();
  for (int i = 0; i < n; i++)
  {
    getline(cin, a[i]);
  }
  for (int i = 0; i < n; i++)
  {
    count1 = 0;
    count2 = 0;
    kq(a[i], count1, count2);
    if (count1 > count2)
      cout << "Alice " << count1 - count2 << endl;
    if (count1 < count2)
      cout << "Bob " << count2 - count1 << endl;
  }
  return 0;
}