using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.Classes
{
    class StudentEnumerator : IEnumerator<Student>
    {
        private List<Student> _list;

        private int _position = -1;

        public StudentEnumerator(List<Student> list)
        {
            _list = list.GetRange(0, list.Count);
            Reset();
        }

        public Student Current
        {
            get { return _list[_position]; }
        }

        public void Dispose() { }

        object System.Collections.IEnumerator.Current
        {
            get { return this; }
        }

        public bool MoveNext()
        {
            return ++_position < _list.Count;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
