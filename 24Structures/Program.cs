using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1, "mark");     // init with constructor
            c1.PrintDetails();

            Customer c2 = new Customer();              // init with Prop
            c2.Id = 2;
            c2.Name = "Arya";
            c2.PrintDetails();

            Customer c3 = new Customer                //   init with obj initializer syntax
            {
                Id = 3,
                Name = "Rob"
            };

            c3.PrintDetails();


        }
    }



    struct Customer   // structs are same as class but use some less memory
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Id is {id} Name is {name}");
        }

    }

}



