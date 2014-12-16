using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_9.Classes
{
    class FileWriter : FileReader
    {
        private int iterator;

        public int Answer { get; set; }

        public FileWriter()
        {
            iterator = 0;
        }

        public void Rand()
        {
            Random rnd = new Random();
            iterator = rnd.Next(30)
                
                
                ;
            for (int i = 0;  i < iterator;  i++)
            {
                Answer += iterator;
            }
        }

        ~FileWriter()
        {
            Console.WriteLine("Destructor FileWriter is running");
        }

        
    }
}
