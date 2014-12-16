using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.Classes
{
    class Student : IComparable
    {
        private string _firstName;
        private string _lastName;
        private int _dateBirth;
        private string _school;
        private string _home;

        public int CompareTo(object obj)
        {
            Student std = (Student)obj;
            return this._dateBirth.CompareTo(std._dateBirth);
        }

        public Student(Parameters parameters)
        {
            _firstName = parameters.FirstName;
            _lastName = parameters.LastName;
            _dateBirth = parameters.DateBirth;
            _school = parameters.School;
            _home = parameters.Home;
        }

        public override string ToString()
        {
            return string.Format("{0}  {1}  {2}  {3}  {4}", _firstName, _lastName, _dateBirth, _school, _home);
        }

        public class Parameters
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int DateBirth { get; set; }
            public string School { get; set; }
            public string Home { get; set; }
        }

    }
}
