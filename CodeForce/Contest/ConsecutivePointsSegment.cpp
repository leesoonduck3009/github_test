#include <iostream>
using namespace std;
void merge(int a[], int left, int mid, int right)
{
  int *tmp = new int[left + right + 1];
  int p = 0;
  int phantrai = left;
  int phanphai = mid + 1;
  while (!(phantrai > mid && phanphai > right))
  {
    if ((phantrai <= mid && phanphai <= right && a[phantrai] < a[phanphai]) || phanphai > right)
      tmp[p++] = a[phantrai++];
    else
    {
      tmp[p++] = a[phanphai++];
    }
  }
  for(int i=0;i<p;i++)
  {
    a[left+i]=tmp[i];
  }
}
void MergeSort(int a[], int left, int right)
{
  if (left < right)
  {
    int mid = (left + right) / 2;
    MergeSort(a, left, mid);
    MergeSort(a, mid + 1, right);
    merge(a, left, mid, right);
  }
}
void SapTang(int a[], int n)
{
  MergeSort(a, 0, n - 1);
}

int check(int a[],int n)
{
  if(n==1)
  return 1;
  for(int i=1;i<n;i++)
  {
    if(a[i]-a[i-1]>2)
      return 0;
    else if(a[i]-a[i-1]==1)
    {
      a[i]+=1;
      a[i-1]+=1;
    }
    else if(a[i]-a[i-1]==2)
    {
      a[i]-=1;
      a[i-1];
    }
  }
  return 1;
}
int main()
{
  long n;
  long k;
  int a[200000];
  int b;
  int c[20000];
  cin >> n;
  for(long i=0;i<n;i++)
  {
    cin >> b;
    for(long j=0;j<b;j++)
    {
      cin >> a[j];
    }

    c[i]=check(a,b);
  }
  for(long i=0;i<n;i++)
  {
      if(c[i]==0)
        cout << "NO\n";
      else
      {
        cout << "YES\n";
      }


  }


}