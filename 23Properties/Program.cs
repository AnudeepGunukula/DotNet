using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Properties
{


    class Student
    {
        private int Id;
        private string Name;
        private int PassMark = 35;


        public int GetPassMark()
        {
            return this.PassMark;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cant be empty");
            }
            this.Name = Name;
        }

        public string GetName()
        {
            return (string.IsNullOrEmpty(this.Name)) ? "No Name" : this.Name;
        }
        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("student id cant be negative");
            }
            this.Id = Id;
        }

        public int GetId()
        {
            return this.Id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();
            s1.SetId(101);
            s1.SetName("light");

            Console.WriteLine($"Id is {s1.GetId()} and Name is {s1.GetName()} and PassMark is {s1.GetPassMark()}");
        }


    }
}
