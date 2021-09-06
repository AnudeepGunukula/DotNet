using System;

namespace stringType
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "\"bagath\"";               //escape character is \ (backslash)
            Console.WriteLine(name);


            Console.WriteLine("One\nTwo\nThree");


            string path = "C:\\users\\Anudeep\\Desktop\\Program.cs";        //every time adding \ to keep \ is not readable
            Console.WriteLine(path);


            //verbatime Literal

            string path1 = @"C:\Users\Anudeep\Desktop\Program.cs";            // treat escape sequence as regular printable characters

            Console.WriteLine(path1);



        }
    }
}
