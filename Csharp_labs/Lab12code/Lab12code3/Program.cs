using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12code3
{
    class Program
    {
        public static string dir;
        static void Main(string[] args)
        {

            string pwd = Directory.GetCurrentDirectory();

            while (true)
            {
                Console.WriteLine("1)Create Directory");
                Console.WriteLine("2)Give Batch Details");
                Console.WriteLine("3)Backup in D drive");
                Console.WriteLine("4)View the text files");
                Console.WriteLine("5)quit");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 1 || i > 4)
                {
                    break;
                }
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter the Directory name u want to create");
                        Program.dir = Console.ReadLine();

                        DirectoryInfo di = new DirectoryInfo(dir);
                        if (!di.Exists)
                        {
                            di.Create();
                        }
                        else
                        {
                            Console.WriteLine($"directory {dir} already exists");
                        }
                        Console.Write("enter the number of subdirectories u want to create:");

                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < n; j++)
                        {

                            Console.Write($"Enter the subdirectory{j + 1} name u want to create:");
                            string sub = Console.ReadLine();
                            string path = pwd + "/" + dir + "/" + sub;


                            if (!Directory.Exists(path))
                            {
                                di.CreateSubdirectory(sub);
                            }
                            else
                            {
                                Console.WriteLine($"subdirectory {sub} already exists");
                            }

                            Console.Write("Enter the filename u want to create in this subdir :");
                            string filename = Console.ReadLine();
                            filename = path + "/" + filename;
                            if (!File.Exists(filename))
                            {
                                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                                fs.Close();
                            }
                            else
                            {
                                Console.WriteLine($"file already exists");
                            }

                        }
                        break;

                    case 2:
                        Console.WriteLine("=>Chennai");
                        Console.WriteLine("=>Bangalore");
                        Console.WriteLine("=>Mumbai");
                        Console.WriteLine("=>Pune");
                        Console.Write("Enter the Location name of the batch :");

                        String loc = Console.ReadLine();

                        string fpath = pwd + "/" + dir + "/" + loc + "/" + loc + ".txt";
                        if (File.Exists(fpath))
                        {
                            FileStream ff = new FileStream(fpath, FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(ff);
                            Console.Write("Enter the batch id :");
                            sw.Write($"Batch id is {Console.ReadLine()}\n");
                            Console.Write("Enter the batch name :");
                            sw.Write($"Batch name is {Console.ReadLine()}\n");
                            Console.Write("Enter the total batch count: ");
                            sw.Write($"Batch count is {Console.ReadLine()}\n");
                            Console.Write("Enter the batch starting date: ");
                            sw.Write($"Batch starting date is {Console.ReadLine()}\n");
                            sw.Write($"Batch Location is {loc}\n");

                            sw.Close();
                        }
                        else
                        {
                            Console.WriteLine("file doesn't exist go to step 1 to create");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Enter the folder name u want to backup");
                        string fol = Console.ReadLine();
                        string fol2 = "D:\\" + fol;
                        Console.WriteLine($"Creating Backup of {fol} folder in D drive");
                        DirectoryInfo dii = new DirectoryInfo(fol2);
                        dii.Create();
                        string pathh = pwd + "\\" + fol;
                        foreach (var x in Directory.GetDirectories(pathh))
                        {


                            string[] st = x.Split('\\');
                            string dfol = "D:\\" + fol + "\\" + st[st.Length - 1];
                            DirectoryInfo dif = new DirectoryInfo(dfol);
                            dif.Create();
                            string[] f = Directory.GetFiles(x);
                            string source = f[0];
                            string[] spl = f[0].Split('\\');
                            string dest = dfol + "\\" + spl[spl.Length - 1];
                            FileStream fs = new FileStream(source, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            StreamReader sr = new StreamReader(fs);
                            string data = sr.ReadLine();
                            FileStream fd = new FileStream(dest, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            StreamWriter sw = new StreamWriter(fd);
                            while (data != null)
                            {
                                sw.Write(data + "\n");
                                data = sr.ReadLine();
                            }
                            sw.Close();
                            fd.Close();
                            fs.Close();
                            sr.Close();

                        }

                        break;
                    case 4:
                        if (dir == null)
                        {
                            Console.WriteLine("Enter the text file path to show content");
                            string ppt = Console.ReadLine();
                            FileStream fss = new FileStream(ppt, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            StreamReader sr = new StreamReader(fss);
                            Console.WriteLine(sr.ReadToEnd());
                            sr.Close();
                            fss.Close();
                        }
                        else
                        {
                            string pat = pwd + "/" + dir;
                            string[] d = Directory.GetDirectories(pat);

                            foreach (var x in d)
                            {

                                string[] files = Directory.GetFiles(x);

                                FileStream fs = new FileStream(files[0], FileMode.OpenOrCreate, FileAccess.ReadWrite);
                                StreamReader sr = new StreamReader(fs);
                                Console.WriteLine($"this is data from {files[0]}");
                                Console.WriteLine();
                                Console.WriteLine(sr.ReadToEnd());
                                Console.WriteLine("======================================================");
                                sr.Close();
                                fs.Close();

                            }
                        }
                        break;

                    default:
                        break;

                }
            }



        }
    }
}
