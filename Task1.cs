using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegaty
{
    internal class Task1
    {
        public delegate int MyDelegate(int a, int b);

        public static int Plus(int a,int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static  int Myltiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
           
            return a / b;
        }


        public static void task1()
        {
            MyDelegate _delegate = null;

            Console.WriteLine("enter two numbers -> ");
            int first = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int res = 0;
            Console.WriteLine("enter operation (+,-,*,/) ");
            string oper = Console.ReadLine();


            switch (oper)
            {
                case "+":
                    _delegate = Plus;
                    break;
                    case "-":
                    _delegate = Minus;
                    break;
                    case "*":
                    _delegate = Myltiply;
                    break;
                    case "/":
                    _delegate = Divide;
                    break;


            }
             res = _delegate(first, two);

            Console.WriteLine($"result = {res}");
        }



    }
}
