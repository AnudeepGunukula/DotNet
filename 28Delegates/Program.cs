using System;

namespace _28Delegates
{
    class Program
    {
        public delegate void HelloDelegate(string msg);

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
        static void Main(string[] args)
        {
            HelloDelegate handler = Hello;

            handler("Hello delegates");
            //delegate is a type safe function pointer

        }
    }
}
