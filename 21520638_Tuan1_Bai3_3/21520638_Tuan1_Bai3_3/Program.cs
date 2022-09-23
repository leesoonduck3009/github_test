using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21520638_Tuan1_Bai3_3
{
    internal class Program
    {
        //static void ChuanHoa(ref string a)

        static void ChuanHoaChuoi(ref string str)
        {
            
            string[] strArr = str.Split(' ');
            str = "";
            foreach(string str2 in strArr)
            {
                  str+=char.ToUpper(str2[0]);
                for (int i=1;i<str2.Length;i++)
                {
                    str+=char.ToLower(str2[i]);
                }
                str += " ";
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi: ");
            string a=Console.ReadLine();
            ChuanHoaChuoi(ref a);
            Console.WriteLine("Chuoi da chuan hoa: " + a);
           // a[0] = '5';
            Console.ReadKey();
        }
    }
}
