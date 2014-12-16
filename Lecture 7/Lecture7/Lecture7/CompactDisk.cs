using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7
{
    class CompactDisk:IDictionary<string,string>
    {
        private Dictionary<string, string> _song = new Dictionary<string, string>();

        public string NameAlbum { get; set; }

        public CompactDisk()
        {
            NameAlbum = "Album";
            _song.Add("Artist","Song");
        }

        public CompactDisk(string aName, Dictionary<string,string> song)
        {
            NameAlbum = aName;
            _song = song;
        }

        public void Add(string key, string value)
        {
            _song.Add(key, value);
        }

        public bool ContainsKey(string key)
        {
            return _song.ContainsKey(key);
        }

        public ICollection<string> Keys
        {
            get { return _song.Keys; }
        }

        public bool Remove(string key)
        {
            return _song.Remove(key);
        }

        public bool TryGetValue(string key, out string value)
        {
            return _song.TryGetValue(key, out value);
        }

        public ICollection<string> Values
        {
            get { return _song.Values; }
        }

        public string this[string key]
        {
            get
            {
                return _song[key];
            }
            set
            {
                _song[key] = value;
            }
        }

        public void Add(KeyValuePair<string, string> item)
        {
            _song.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            _song.Clear();
        }

        public bool Contains(KeyValuePair<string, string> item)
        {
            return _song.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return _song.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(KeyValuePair<string, string> item)
        {
            return _song.Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return _song.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Album -> {0}{1}", NameAlbum, Environment.NewLine);

            foreach (var item in _song)
            {
                str.AppendFormat("{0} - {1}{2}", item.Key, item.Value, Environment.NewLine);
            }
               
            
            return str.ToString();
        }
    }
}
