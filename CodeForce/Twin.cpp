#include <iostream>
using namespace std;
void Merge(int a[], int left, int mid, int right)
{
  int *temp = new int[right - left + 1];
  int PhiaPhai = mid + 1;
  int PhiaTrai = left;
  int p = 0;
  while (!(PhiaPhai > right && PhiaTrai > mid))
  {
    if ((PhiaPhai <= right && PhiaTrai <= mid && a[PhiaTrai] < a[PhiaPhai]) || PhiaPhai > right)
      temp[p++] = a[PhiaTrai++];
    else
    {
      temp[p++] = a[PhiaPhai++];
    }
  }
  for (int i = 0; i < p; i++)
  {
    a[left + i] = temp[i];
  }
}
void MergeSort(int a[], int left, int right)
{
  if (left < right)
  {
    int mid = (left + right) / 2;
    MergeSort(a, left, mid);
    MergeSort(a, mid + 1, right);
    Merge(a, left, mid, right);
  }
}
void Saptang(int a[], int n)
{
  MergeSort(a, 0, n - 1);
}
int check(int a[],int n)
{
  int count=0;
  int tong=0;
  int tong2=0;

  for(int i=0;i<n;i++)
  {
    tong+=a[i];
  }
  while(tong2<=tong)
  {
    tong2+=a[n-1];
    tong-=a[n-1];
    n--;
    count++;
  }
  return count;
}
int main()
{
  int n;
  int a[100];
  cin >> n;
  for (int i = 0; i < n; i++)
  {
    cin >> a[i];
  }
  Saptang(a, n);
  cout << check(a,n);
}