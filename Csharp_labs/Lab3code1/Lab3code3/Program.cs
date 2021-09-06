using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3code3
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            Car[] cobj = new Car[10];
            while (true)
            {

                Console.WriteLine("1) Adding a new Car ");
                Console.WriteLine("2) Modify the details of particular car ");
                Console.WriteLine("3) Search for particular car in the catalog ");
                Console.WriteLine("4) List all the cars in the Catalog ");
                Console.WriteLine("5) Delete a car from the Catalog ");
                Console.WriteLine("6) Quit");
                Console.Write("Enter your option : ");

                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 6)
                {
                    break;
                }
                switch (num)
                {
                    case 1:

                        cobj[i] = new Car();
                        Console.Write("Enter the Car's make : ");
                        cobj[i].Make = Console.ReadLine();
                        Console.Write("Enter the Car's model : ");
                        cobj[i].Model = Console.ReadLine();
                        Console.Write("Enter the Car's Year: ");
                        cobj[i].Year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Car's saleprice : ");
                        cobj[i].Saleprice = Convert.ToDouble(Console.ReadLine());
                        i += 1;
                        break;
                    case 2:

                        for (int k = 1; k <= i; k++)
                        {
                            Console.WriteLine($"{k} : {cobj[k - 1].Make}");
                        }
                        Console.WriteLine("Which car do you want to modify : ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"1)Car's Make : {cobj[choice].Make}");
                        Console.WriteLine($"2)Car's Model : {cobj[choice].Model}");
                        Console.WriteLine($"3Car's Year : {cobj[choice].Year}");
                        Console.WriteLine($"4)Car's Saleprice : {cobj[choice].Saleprice}");
                        Console.WriteLine();
                        Console.Write("Enter the number u want to modify :");
                        int prop = Convert.ToInt32(Console.ReadLine());
                        if (prop == 1)
                        {
                            Console.WriteLine("modify the car's make to :");
                            cobj[choice].Make = Console.ReadLine();
                        }
                        else if (prop == 2)
                        {
                            Console.WriteLine("modify the car's Model to :");
                            cobj[choice].Model = Console.ReadLine();
                        }
                        else if (prop == 3)
                        {
                            Console.WriteLine("modify the car's year to :");
                            cobj[choice].Year = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (prop == 4)
                        {
                            Console.WriteLine("modify the car's saleprice to :");
                            cobj[choice].Saleprice = Convert.ToDouble(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("please enter valid property ");
                        }
                        break;

                    case 3:
                        Console.WriteLine("enter the car make u want to search : ");
                        string search = Console.ReadLine();
                        for (int z = 0; z < i; z++)
                        {
                            if (cobj[z].Make == search)
                            {
                                Console.WriteLine("car make : {0}", cobj[z].Make);
                                Console.WriteLine("car model : {0}", cobj[z].Model);
                                Console.WriteLine("car year : {0}", cobj[z].Year);
                                Console.WriteLine("car saleprice : {0}", cobj[z].Saleprice);
                            }

                        }
                        break;
                    case 4:
                        for (int z = 0; z < i; z++)
                        {
                            Console.WriteLine("car make : {0}", cobj[z].Make);
                            Console.WriteLine("car model : {0}", cobj[z].Model);
                            Console.WriteLine("car year : {0}", cobj[z].Year);
                            Console.WriteLine("car saleprice : {0}", cobj[z].Saleprice);
                        }
                        break;
                    case 5:
                        for (int k = 1; k <= i; k++)
                        {

                            Console.WriteLine($"{k} : {cobj[k - 1].Make}");
                        }
                        Console.WriteLine("Which car do you want to delete : ");

                        int delchoice = Convert.ToInt32(Console.ReadLine());
                        delchoice = delchoice - 1;
                        Console.WriteLine(delchoice);
                        Car a;
                        a = cobj[delchoice];
                        Console.WriteLine(a.Make + "  and i value is " + i);
                        cobj[delchoice] = cobj[i - 1];

                        cobj[i - 1] = a;
                        Console.WriteLine(cobj[i - 1].Make);


                        Console.WriteLine($"you have succesfully deleted {cobj[i - 1].Make} record");
                        i = i - 1;
                        break;

                    default:
                        Console.WriteLine("please enter valid option ");

                        break;
                }
                Console.WriteLine();

            }


        }
    }
}
