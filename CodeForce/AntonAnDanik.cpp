#include <iostream>
#include <string>
using namespace std;
int main()
{
  string game;
  int n;
  int countD=0;
  int countA=0;
  cin >> n;
  cin.ignore();
  getline(cin,game);
  for(int i=0;i<game.size();i++)
  {
    if(game[i]=='A')
    countA++;
    else if(game[i]=='D')
    countD++;
  }
  if(countA>countD)
  cout << "Anton";
  else if(countA<countD)
  cout << "Danik";
  else
  {
    cout << "Friendship";
  }
  return 0;
}