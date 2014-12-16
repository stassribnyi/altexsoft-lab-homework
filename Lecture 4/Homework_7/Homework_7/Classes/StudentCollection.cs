using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.Classes
{
    class StudentCollection : IEnumerable<Student>
    {
        private List<Student> _list;

        public StudentCollection()
        {
            _list = new List<Student>();
        }

        public StudentCollection(List<Student> list)
        {
            _list = list.GetRange(0, list.Count);
        }

        public void Add(Student stud)
        {
            _list.Add(stud);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return new StudentEnumerator(_list);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public void Sort()
        {
            _list.Sort();
        }
    }
}
