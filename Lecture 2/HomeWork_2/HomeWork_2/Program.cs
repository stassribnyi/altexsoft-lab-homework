using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeWork_2
{
    struct Student: IComparable
    {
        public string _firstName;
        public string _lastName;
        public int _age;
        public string _group;
        public int CompareTo(object obj)
        {
           Student str = (Student)obj;
            return this._firstName.CompareTo(str._firstName);
        }
    }
    class StudentCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            Student first = (Student)x;
            Student second = (Student)y;
            if (first._age < second._age)
                return -1;
            else if (first._age > second._age)
                return 1;
            else return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 5;
            StudentCompare studComp = new StudentCompare();
            Student[] stud = new Student[size];
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                stud[i]._age = rnd.Next(1,25);
                stud[i]._firstName = "fName"+rnd.Next(1,200);
                stud[i]._group = "grp" + rnd.Next(0, 10);
                stud[i]._lastName = "lName"+rnd.Next();
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Age: {0}", stud[i]._age);
            }

            Array.Sort(stud, studComp);     //Сортиовка по возрасту
            for (int i = 0; i < size; i++)
            {
                str.AppendFormat("Name: {0}, Last: {1}, Group: {2}, Age: {3}{4}",
                                stud[i]._firstName, stud[i]._lastName,
                                stud[i]._group, stud[i]._age, Environment.NewLine);
            }
            Console.WriteLine(str);

            str = new StringBuilder();

            Array.Sort(stud);               //Сортирвка по имени
            for (int i = 0; i < size; i++)
            {
                str.AppendFormat("Name: {0}, Last: {1}, Group: {2}, Age: {3}{4}",
                                stud[i]._firstName, stud[i]._lastName,
                                stud[i]._group, stud[i]._age, Environment.NewLine);
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
