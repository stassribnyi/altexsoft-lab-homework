using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5.Classes
{
    class Teacher : Person
    {
        private string _predmet;
        private Student[] _stud;

        public static Teacher RandomTeacher(List<Teacher> _pList)
        {
            Random rand = new Random();
            return _pList[rand.Next(0, _pList.Count - 1)];
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", FirstName, LastName, Age, _predmet, _stud);
        }

    }
}
