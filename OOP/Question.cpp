#include <iostream>
using namespace std;
struct Question
{
  string Ques;
  string ans1;
  string ans2;
  string ans3;
  string ans4;
  char answer;
  int question;
};
void AddQuestion(Question a,string ques,string a1,string a2,string a3,string a4,char ans,int question)
{
  a.Ques=ques;
  a.ans1=a1;
  a.ans2=a2;
  a.ans3=a3;
  a.ans4=a4;
  a.answer=ans;
  a.question=question;
}
void CheckAnswer(Question a1,char a,char q,int& point)
{
  if(a1.answer=a)
  {

  }
}
int main()
{
  Question a1;


}