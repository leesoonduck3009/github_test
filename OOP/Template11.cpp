#include <cstdlib>
#include <ctime>
#include <iostream>
using namespace std;
int main()
{
	srand(time(NULL));
  for(int i=0;i<8;i++)
	  cout << rand()%50 << " ";
	return 0;
}