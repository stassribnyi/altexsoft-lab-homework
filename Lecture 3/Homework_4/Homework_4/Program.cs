using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader fileIn = new StreamReader(@"..\..\text.txt", Encoding.GetEncoding(1251));
            string line;
            StringBuilder str = new StringBuilder();

            while ((line = fileIn.ReadLine()) != null)//пока поток не пуст
            {
                str.AppendLine(line);
            }
            line = str.ToString();
            int sum = 0;
            
            string[] splitStr = line.Split(new Char [] {' ', ',', '.', ':','{','}', '\t' });
            int[] res = new int[splitStr.Length];
            for (int i = 0; i < splitStr.Length;i++ )
            {

                if (splitStr[i].Trim() != "")
                {
                    int.TryParse(splitStr[i], out res[i]);
                    sum += res[i];
                    Console.WriteLine(res[i]);
                   
                }
            }
            fileIn.Close();
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
