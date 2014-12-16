using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_6
{
    class Explore
    {
        public void Read(string way)
        {
           
            DirectoryInfo dir = new DirectoryInfo(way);
            DirectoryInfo[] massDir = dir.GetDirectories();
            foreach (var elem in massDir)
            {
                Console.WriteLine("dir-- {0}, ->{1}", elem.Name, elem.GetDirectories().Length);
                FileInfo[] massFiles = dir.GetFiles();
                foreach (var fl in massFiles)
                {
                    Console.WriteLine("file-- {0}", fl.Name);
                }
                
                if (elem.GetDirectories().Length == 0)
                {
                    way = elem.Parent.Name; 
                }
                else
                {
                    way = elem.FullName;
                    Read(way);
                }
            }
        }
 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Explore newExp = new Explore();
            newExp.Read(@"..\..\..\..\..\");
            Console.ReadKey();
        }

    }
}
