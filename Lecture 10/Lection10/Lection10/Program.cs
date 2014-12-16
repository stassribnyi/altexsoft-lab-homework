using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection10
{
    class SomeClass
    {
        public static void SomeStaticMethod(string arg)
        {
            Console.WriteLine("Статический метод говорит: " + arg);
        }

        public void SomeInstanceMethod(string arg)
        {
            Console.WriteLine("Метод экземпляра говорит: " + arg);
        }
    }

    class Program
    {
        public delegate void SomeDelegate(string arg);

        delegate int LengthLogin(string s);

        delegate bool BoolPassword(string s1, string s2);

        delegate void Capcha(string arg1, string arg2);

        static void Main()
        {
            SomeDelegate del = null;


            SomeDelegate staticDelegate = new SomeDelegate(SomeClass.SomeStaticMethod);
            staticDelegate("Привет Мир!");

            SomeClass someObj = new SomeClass();

            staticDelegate += someObj.SomeInstanceMethod; ;
            staticDelegate("Мир Привет!");

            staticDelegate += SomeClass.SomeStaticMethod;

            del += SomeClass.SomeStaticMethod;
            del += someObj.SomeInstanceMethod;
            foreach (SomeDelegate item in del.GetInvocationList())
            {
                item("Привет Мир!");
            }

            SomeDelegate someDelegate = delegate(String arg)
            {
                Console.WriteLine(arg);
            };
            someDelegate("ChupaChups");

            Console.ReadKey();

            string login = "Albert", password1 = "E=mc^2", password2 = "E=mc^2", resCapcha = "asd", resCode = "asd1";


            LengthLogin ll = ss => ss.Length;
            int longlogin = ll(login);


            BoolPassword bp = (s1, s2) => s1 == s2;

            if (bp(password1, password2)) //Checking password
            {
                Console.WriteLine("Регистрация удалась!");
            }
            else
            {
                Console.WriteLine("Регистрация провалилась. Пароли не совпадают");
            }

            Console.ReadKey();

            Capcha cp = (s1, s2) =>
            {
                if (s1 == s2)
                {
                    Console.WriteLine("Регистрация удалась!");
                }
                else
                {
                    Console.WriteLine("Не переживай, в следующий раз получится :)");
                }
                return;
            };

            cp(resCapcha, resCode);//Checking capcha

            Console.ReadKey();

        }
    }
}
