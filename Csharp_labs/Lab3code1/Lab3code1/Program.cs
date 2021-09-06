using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using code1Logic;
namespace Lab3code1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number of Participants : ");
            int count = Convert.ToInt32(Console.ReadLine());
            Participant[] parr = new Participant[count];
            for (int i = 0; i < count; i++)
            {
                parr[i] = new Participant();
                Console.Write("Enter the EmpId : ");
                parr[i].EmpId1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the CompanyName : ");
                parr[i].CompanyName1 = Console.ReadLine();
                Console.Write("Enter the Foundation Marks : ");
                parr[i].FoundationMarks1 = Convert.ToInt32(Console.ReadLine());
                if (parr[i].FoundationMarks1 < 0 || parr[i].FoundationMarks1 > 100)
                {
                    parr[i].FoundationMarks1 = 0;
                }
                Console.Write("Enter the WebBasic Marks : ");
                parr[i].WebBasicMarks1 = Convert.ToInt32(Console.ReadLine());
                if (parr[i].WebBasicMarks1 < 0 || parr[i].WebBasicMarks1 > 100)
                {
                    parr[i].WebBasicMarks1 = 0;
                }
                Console.Write("Enter the DotNet Marks : ");
                parr[i].DotNetMarks1 = Convert.ToInt32(Console.ReadLine());
                if (parr[i].DotNetMarks1 < 0 || parr[i].DotNetMarks1 > 100)
                {
                    parr[i].DotNetMarks1 = 0;
                }

            }
            for (int i = 0; i < count; i++)
            {
                parr[i].calcomarks();
                parr[i].calcpercentage();
                Console.WriteLine($"the percentage obtained for {parr[i].EmpId1} is {parr[i].retperc()}%");
            }
        }
    }
}
