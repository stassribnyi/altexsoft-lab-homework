using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7
{
    class Folder : IList<CompactDisk>
    {
        private List<CompactDisk> _album = new List<CompactDisk>();

        public int IndexOf(CompactDisk item)
        {
            return _album.IndexOf(item);
        }

        public void Insert(int index, CompactDisk item)
        {
            _album.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _album.RemoveAt(index);
        }

        public CompactDisk this[int index]
        {
            get
            {
                return _album[index];
            }
            set
            {
                _album[index] = value;
            }
        }

        public void Add(CompactDisk item)
        {
            _album.Add(item);
        }

        public void Clear()
        {
            _album.Clear();
        }

        public bool Contains(CompactDisk item)
        {
            return _album.Contains(item);
        }

        public void CopyTo(CompactDisk[] array, int arrayIndex)
        {
            _album.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _album.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(CompactDisk item)
        {
            return _album.Remove(item);
        }

        public IEnumerator<CompactDisk> GetEnumerator()
        {
            return _album.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            foreach (var item in _album)
            {
                str.AppendFormat("{0}{1}", item, Environment.NewLine);
            }
            return str.ToString();
        }
    }
}
