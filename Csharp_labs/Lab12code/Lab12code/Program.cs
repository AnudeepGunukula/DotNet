using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab12code
{

    class EmptyFileException : Exception
    {
        public EmptyFileException()
        {

        }
        public EmptyFileException(string str) : base(str)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text file u want to display:");
            string filename = Console.ReadLine();
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("File is not Found");
            }

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            var data = sr.ReadLine();
            if (data == null)
            {
                throw new EmptyFileException("File is empty");
            }

            while (data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();
            }

        }
    }
}
