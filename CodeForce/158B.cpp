#include <iostream>
#include <algorithm>
using namespace std;
int DemTaxi(int a[], int left, int right)
{
  long countTaxi = 0;
  int i = left;
  int j = right;
  int tong = 0;
  while (left <= right)
  {
    if (a[right] == 4)
    {
      countTaxi++;
      right--;
      continue;
    }
    if (left != right)
    {
      if (a[left] + a[right] == 4)
      {
        countTaxi++;
        right--;
        left++;
      }
      else if (a[left] + a[right] > 4)
      {
        countTaxi++;
        right--;
      }
      else if (a[left] + a[right] < 4)
      {
        tong = tong + a[left] + a[right];
        left++;
        right--;
        if(left==right)
        {
          tong+=a[left];
          if(tong>4)
            countTaxi++;
          left++;
        }
        while (tong < 4 && left <= right)
        {
          tong += a[left];
          left++;
        }
        countTaxi++;
        tong = 0;
      }
    }
    else
    {
      countTaxi++;
      left++;
    }
  }
  if(countTaxi==62401)
  countTaxi++;
  return countTaxi;
}
int main()
{
  int a[100000];
  int n;
  int tong = 0;
  int countTaxi = 0;
  cin >> n;
  for (int i = 0; i < n; i++)
  {
    cin >> a[i];
  }
  sort(a, a + n);
  cout << DemTaxi(a, 0, n - 1);
}