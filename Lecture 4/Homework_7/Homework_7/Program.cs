using Homework_7.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCollection = new StudentCollection
            { 
                new Student(
                    new Student.Parameters
                    {
                        FirstName = "Name2",
                        LastName = "Lsd3",
                        DateBirth = 1994,
                        School = "173",
                        Home = "Home"
                    }),

                     new Student(
                    new Student.Parameters
                    {
                        FirstName = "Name34",
                        LastName = "Lsd3",
                        DateBirth = 1999,
                        School = "173",
                        Home = "Home"
                    }),

                     new Student(
                    new Student.Parameters
                    {
                        FirstName = "Name341",
                        LastName = "Lsd3",
                        DateBirth = 1991,
                        School = "173",
                        Home = "Home"
                    })

            };

            foreach (var item in myCollection)
            {
                Console.WriteLine("{0}{1}",item,Environment.NewLine);
            }
            

            myCollection.Sort();

            foreach (var item in myCollection)
            {
                Console.WriteLine("{0}{1}", item, Environment.NewLine);
            }
            Console.ReadKey();
        }
    }
}
