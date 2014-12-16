using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ6
{
    public static class PowExtention
    {
        public static int Power(this int value, double pow)
        {
            if (pow > 0)
            {
                return (int)Math.Pow(value, pow);
            }
            else 
                throw new Exception("Variable do not is <0");
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int variable = 6;
            var nv= variable.Power(0.5);
            Console.ReadKey();
        }
    }
}
