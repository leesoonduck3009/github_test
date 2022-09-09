#include <iostream>
using namespace std;
int main()
{
  int a;
  cin >> a;
  for(int i=1;i<=a;i++)
  {
    if(i>=2)
    cout << "that ";
    if(i%2==1)
    cout << "I hate ";
    else
    cout << "I love ";
  }
  cout << "it";
}