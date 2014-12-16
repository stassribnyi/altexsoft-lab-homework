using PZ5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person psn = new Teacher();
            Teacher tch = new Teacher();
            
            psn.FirstName = "Pavel";
            psn.LastName = "Kesha";
            psn.Age = 19;
            psn.Print();
            Console.ReadKey();
        }
    }
}
