using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12code2
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
            Console.WriteLine("Enter the original file name:");
            string filename = Console.ReadLine();
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("File is not Found");
            }
            Console.WriteLine("Enter the Duplicate file name:");
            string filename2 = Console.ReadLine();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);
            FileStream fw = new FileStream(filename2, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs);
            BinaryWriter bw = new BinaryWriter(fw);
            var data = br.ReadBytes(1024);
            if (data == null)
            {
                throw new EmptyFileException("File is empty");
            }
            while (data != null)
            {
                bw.Write(data);
                data = br.ReadBytes(1024);
                if (data.Length < 1024)
                {
                    bw.Write(data);
                    break;
                }
            }

        }
    }
}
