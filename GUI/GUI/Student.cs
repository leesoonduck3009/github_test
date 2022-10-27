using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace GUI
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Avg { get; set; }
        public string Class { get; set; }
        public Student(int id, string name, float avg, string @class)
        {
            Id = id;
            Name = name;
            Avg = avg;
            Class = @class;
        }
        public override string ToString()
        {
            return Id.ToString() + "/" + Name + "/" + Class +  "/" + Avg.ToString() + "\n";
        }
        public Student()
        { }
        public static Student FindStrStudent(string MSSV)
        {
            string[] ListStudent = File.ReadAllLines("data.txt");
            Student a;
            for (int i = 0; i < ListStudent.Length; i++)
            {
                string[] listDataStudent = ListStudent[i].Split('/');
                if (listDataStudent[0] == MSSV)
                {
                     a = new Student(int.Parse(listDataStudent[0]), listDataStudent[1], float.Parse(listDataStudent[3]), listDataStudent[2]);
                    return a;
                }    
            }
            return new Student();
        }
        public static bool FindStudent(string MSSV)
        {
            string[] ListStudent= File.ReadAllLines("data.txt");
            for (int i = 0; i < ListStudent.Length; i++)
            {
                string[] listDataStudent= ListStudent[i].Split('/');
                if (listDataStudent[0]== MSSV)
                    return true;
            }
            return false;
        }    
        public static void SaveStudent(Student temp)
        {
            if (File.Exists("data.txt") == false)
                File.WriteAllText("data.txt", temp.ToString());
            else
                File.AppendAllText("data.txt", temp.ToString());
        }
        public static void UpdateStudent(Student temp)
        {
            List<Student> students = new List<Student>();
            string[] ListStudent = File.ReadAllLines("data.txt");
            for (int i = 0; i < ListStudent.Length; i++)
            {
                string[] listDataStudent = ListStudent[i].Split('/');
                if (temp.Id == int.Parse(listDataStudent[0]))
                {
                    students.Add(temp);
                    continue;
                }
                Student a = new Student(int.Parse(listDataStudent[0]), listDataStudent[1], float.Parse(listDataStudent[3]), listDataStudent[2]);
                students.Add(a);
            }
            string[] str = new string[students.Count];
            int j = 0;
            foreach(Student a in students)
            {
                str[j] = a.ToString();
                str[j]= str[j].Remove(str[j].Length - 1);
                j++;
            }
            File.WriteAllLines("data.txt", str);
        }
    }
}
