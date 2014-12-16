using Lection_9.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_9
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileData nFile = new FileData())
            {
                nFile.Read(@"../../data.txt");
                Console.WriteLine(nFile.FData);
            }

            FileReader reader = new FileReader();
            FileWriter writer = new FileWriter();
            writer.Rand();
            Console.WriteLine(writer.Answer);
       
            Console.ReadKey();
        }
    }
}
