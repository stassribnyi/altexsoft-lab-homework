using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5.Classes
{
    class Person: ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { set; get; }
        
        public virtual void Print()
        {
            Console.WriteLine(this.ToString());        
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", FirstName, LastName, Age);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }

        public static Person RandomPerson(List<Person> _pList)
        {
            Random rand = new Random();
            return _pList[rand.Next(0, _pList.Count-1)];

        }

        //public virtual Person Clone()
        //{
        //    return (Person)this.MemberwiseClone();
        //}

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
