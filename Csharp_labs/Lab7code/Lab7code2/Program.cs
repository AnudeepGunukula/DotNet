using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lab7code2
{
    class Program
    {
        public static bool searched = false;
        public static int ser;
        public static ArrayList arr = new ArrayList();
        static void Main(string[] args)
        {

            Product pd;

            while (true)
            {
                Console.WriteLine("1)Adding new product");
                Console.WriteLine("2)Deleting currently searched product");
                Console.WriteLine("3)Searching product");
                Console.WriteLine("4)Save New Product"); //save in sorted order of pNO
                Console.WriteLine("5)Quit");
                Console.Write("Enter the option:");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 1 || i > 4)
                {
                    break;
                }
                switch (i)
                {
                    case 1:
                        pd = new Product();
                        Console.Write("Enter the Product No:");
                        pd.ProductNo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Product Name:");
                        pd.ProductName = Console.ReadLine();
                        Console.Write("Enter the Product Rate:");
                        pd.Rate = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the Product stock:");
                        pd.Stock = Convert.ToDouble(Console.ReadLine());
                        arr.Add(pd);
                        break;
                    case 2:
                        if (searched)
                        {
                            Console.Write($"The currently searched product is ");
                            for (int z = 0; z < arr.Count; z++)
                            {
                                Product p = (Product)arr[z];
                                if (p.ProductNo == ser)
                                {
                                    Console.WriteLine(p.ProductName);
                                    Console.WriteLine($"Deleting {p.ProductName}");
                                    arr.RemoveAt(z);
                                }
                            }


                        }
                        else
                        {
                            Console.WriteLine($"goto step 3 and search for anything ");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Enter the product num u want to search");
                        int number = Convert.ToInt32(Console.ReadLine());

                        int flag = 0;
                        for (int k = 0; k < arr.Count; k++)
                        {
                            Product p = (Product)arr[k];
                            if (p.ProductNo == number)
                            {
                                Console.WriteLine($"Product Number is :{p.ProductNo}");
                                Console.WriteLine($"Product Name is :{p.ProductName}");
                                Console.WriteLine($"Product Rate is :{p.Rate}");
                                Console.WriteLine($"Product Stock is :{p.Stock}");
                                flag = 1;
                                searched = true;
                                ser = number;
                            }
                        }


                        if (flag == 0)
                        {
                            Console.WriteLine("The product number doesn't exist in array list");
                        }
                        break;
                    case 4:
                        List<Product> list = new List<Product>(arr.Count);
                        foreach (Product instance in arr)
                        {
                            list.Add(instance);
                        }
                        list.Sort();
                        arr = new ArrayList();
                        foreach (var inst in list)
                        {
                            arr.Add(inst);
                        }
                        break;

                    default:
                        break;
                }


            }

        }
    }
}
