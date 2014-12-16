using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeWork_2
{
    class Massive
    {
        public int sizeM;
        public int sizeN;
        public int[,] mass;
        public Massive() 
        {
            Random rnd = new Random();
            Console.Write("Input N:");
            sizeN = Convert.ToInt16(Console.ReadLine());
            Console.Write("Input M:");
            sizeM = Convert.ToInt16(Console.ReadLine());
            mass = new int[sizeN+1,sizeM];
            int sum = 0;
            
            for (int i = 0; i < sizeN; i++)
            {
                for (int j = 0; j < sizeM; j++)
                {
                    mass[i, j] = rnd.Next(-500, 500);
                }
            }
            for (int i = 0; i < sizeM; i++)
            {
                for (int j = 0; j < sizeN; j++)
                {
                   sum += mass[j, i];
                }
                mass[sizeN, i]=sum;
                sum = 0;
            }
        }
        public void Sort()
        {
            int[] tmp = new int[sizeN+1];
            int a=0;
            for (int i = 0; i < sizeM; i++)
            {
                for (var j = i; j < sizeM; j++)
                {
                    if (mass[sizeN, j] < mass[sizeN, i])
                    {
                        for (var k = 0; k < sizeN + 1; k++)
                        {
                            a = mass[k, i];
                            mass[k, i] = mass[k, j];
                            mass[k, j] = a;
                        }
                    }
                }
            }
            
        }
        public void Out()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < sizeN+1; i++)
            {
                for (int j = 0; j < sizeM; j++)
                {
                    str.AppendFormat("{0}     ", mass[i, j]);
                }
                str.AppendFormat(Environment.NewLine);
            }
            
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
    class Program
    {
        public static void Main()
        {
            Massive mass = new Massive();
            mass.Out();
            mass.Sort();
            mass.Out();
        }
        
    }
}
