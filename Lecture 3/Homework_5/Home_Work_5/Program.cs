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
                str.AppendFormat("{0} ", line);
            }
            fileIn.Close();
            StreamWriter fileOut = new StreamWriter(@"..\..\Text.txt", false);
            line = str.ToString();
            string[] strSplit = line.Split(' ');
            double[] mass = new double[strSplit.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                double.TryParse(strSplit[i], out mass[i]);
                mass[i] = Math.Pow(mass[i],2);
                fileOut.Write(mass[i]+" ");
            }
            fileOut.Close();
        }
    }
}
