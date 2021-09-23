using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Properties
{
    class Students
    {

        private int Id;
        private string Name;
        private int PassMark = 35;
        private string city;
        public string Email { get; set; }     // auto Implemented properties doesn't need variable declartion (direct Use)


        public string City { get => city; set => city = value; }

        public int PassMark1
        {
            get => PassMark;    // if single line then do this =>
        }

        public string Name1
        {
            set                          // if multi line then use this
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cant be empty");
                }

                Name = value;
            }

            get
            {
                return string.IsNullOrEmpty(Name) ? "No Name" : Name;
            }
        }

        public int Id1
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("student id cant be negative");
                }
                Id = value;
            }

            // set => Id = value ;            one line set

            get => Id;

        }


    }

    class Prop
    {

        static void Main(string[] args)
        {
            Students s1 = new Students();
            s1.Id1 = 101;
            s1.Name1 = "L";
            s1.Email = "L@yahoo.com";

            Console.WriteLine($"Id is {s1.Id1} and Name is {s1.Name1} and PassMark is {s1.PassMark1}");


            Console.WriteLine($"Email is {s1.Email}");
        }
    }
}
