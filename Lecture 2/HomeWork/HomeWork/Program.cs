using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeWork
{
    class HomeWork
    {
        public void ArrLst()
        {
            ArrayList someAL = new ArrayList();
            someAL.Add("Первый добавленный");
            someAL.Add("Второй добавленный ");
            someAL.Add("Третий добавленный ");
            for (int i = 0; i < someAL.Count; i++)
            {
                Console.WriteLine("{0}ый элемент: {1}", i, someAL[i]);
            }
        }
        public void HashTbl() 
        {
            Hashtable someHT = new Hashtable();
            someHT.Add("Имя", "Иван");
            someHT.Add("Фамилия", "Петров");
            someHT.Add("Отчество", "Владимирович");
            someHT["Должность"]="Разработчик .NET";
            ICollection keysC = someHT.Keys;  
            foreach( string str in keysC)
            {
               Console.WriteLine(str + " : " + someHT[str]);
            }
            Console.WriteLine("Отчество: {0}", someHT["Отчество"]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork myWork = new HomeWork();
            myWork.ArrLst();
            myWork.HashTbl();
            Console.ReadKey();
        }
    }
}
