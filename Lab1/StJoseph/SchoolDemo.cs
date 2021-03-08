using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StJoseph
{
    class SchoolDemo
    {
        static void Main(string[] args)
        {
            int rollNumber = 1;
            string studentName = "Aryan";
            byte age = 22;
            char gender = 'M';
            DateTime dateOfBirth = Convert.ToDateTime("01/01/1999");
            string address = "Mumbai";
            float percentage = 91.2f;

            Console.WriteLine($"the rollnumber of the student is {rollNumber}");
            Console.WriteLine($"the name of the student is {studentName}");
            Console.WriteLine($"the age of the student is {age}");
            Console.WriteLine($"the gender of the student is {gender}");
            Console.WriteLine($"the dateofbirth of the student is {dateOfBirth}");
            Console.WriteLine($"the address of the student is {address}");
            Console.WriteLine($"the percentage of the student is {percentage}");
        }

    }
}
