#include <iostream>
using namespace std;
void Input(int a[][5])
{
  for (int i = 0; i < 5; i++)
  {
    for (int j = 0; j < 5; j++)
      cin >> a[i][j];
  }
}
int check(int a[][5])
{
  int idxrow;
  int idxcol;
  int count = 0;
  for (int i = 0; i < 5; i++)
  {
    for (int j = 0; j < 5; j++)
    {
      if (a[i][j] == 1)
      {
        idxrow = i;
        idxcol = j;
        break;
      }
    }
  }
  while (idxrow != 2)
  {
    if (idxrow < 2)
    {
      idxrow++;
      count++;
    }
    else if (idxrow > 2)
    {
      idxrow--;
      count++;
    }
  }
  while (idxcol != 2)
  {
    if (idxcol < 2)
    {
      idxcol++;
      count++;
    }
    else if (idxcol > 2)
    {
      idxcol--;
      count++;
    }
  }
  return count;
}
int main()
{
  int a[5][5];
  Input(a);
  cout << check(a);
}