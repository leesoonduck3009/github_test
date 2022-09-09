#include <iostream>
#include <string.h>
using namespace std;

int main()
{
  char a[1001];
  cin.getline(a, 1000);
  a[0] = toupper(a[0]);
  puts(a);
}