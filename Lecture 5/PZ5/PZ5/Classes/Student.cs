using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5.Classes
{
    class Student : Person
    {
        public string Group { get; set; }
        public int Kurs { get; set; }
        private Teacher _teacherHead;

        public static Student RandomStudent(List<Student> _pList)
        {
            Random rand = new Random();
            return _pList[rand.Next(0, _pList.Count - 1)];

        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", FirstName, LastName, Age, Group, Kurs, _teacherHead);
        }
    }
}
