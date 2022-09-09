#include <iostream>
using namespace std;
class Matrix
{
  int _col;
  int _row;
  float a[20][20];

public:
  Matrix();
  Matrix(int, int);
  ~Matrix(){};
  float &operator()(int, int);
  friend istream &operator>>(istream &is, Matrix &b);
  friend ostream &operator<<(ostream &os, Matrix &b);
  Matrix operator+(const Matrix& b);
};
Matrix::Matrix()
{
  _row = 0;
  _col = 0;

}
Matrix::Matrix(int i, int j)
{
  _col = i;
  _row = j;
}
float &Matrix::operator()(int i, int j)
{
  return a[i][j];
}

istream &operator>>(istream &is, Matrix &b)
{
  cout << "Nhap so cot: ";
  is >> b._col;
  cout << "Nhap so dong: ";
  is >> b._row;
  for(int i=0; i< b._row;i++)
  {
    for(int j=0;j<b._col;j++)
    {
      is>> b.a[i][j];
    }
  }
  return is;
}
ostream &operator<<(ostream &os, Matrix &b)
{
  for(int i=0; i< b._row;i++)
  {
    for(int j=0;j<b._col;j++)
    {
      os << b(i,j) << " ";
    }
    os << endl;
  }
  return os;
}
Matrix Matrix:: operator+(const Matrix& b)
{
  Matrix kq;
  for(int i=0;i<_col;i++)
  {
    for(int j=0;j<_row;j++)
    {
      //  kq.a[i][j]=a[i][j] + b(i,j);
    }
  }
  return kq;
}


int main()
{
  Matrix a,b,c;
  cin >> a;
  cout << a;
  cout << endl;
  cin >> b;
  cout << b;
  cout << endl;
  c=a+b;
  cout << c;
  return 0;
}