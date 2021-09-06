using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code1Logic
{
    public class Participant
    {
        private int EmpId;
        private static string CompanyName;
        private int FoundationMarks;
        private int WebBasicMarks;
        private int DotNetMarks;
        private float TotalMarks = 300f;
        private float ObtainedMarks;
        private float Percentage;

        public Participant()
        {

        }
        public Participant(int EmpId, string CompanyName, int FoundationMarks, int WebBasicMarks, int DotNetMarks)
        {

        }
        static Participant()
        {
            CompanyName = "Corporate University";
        }
        public int EmpId1 { get => EmpId; set => EmpId = value; }
        public string CompanyName1 { get => CompanyName; set => CompanyName = value; }
        public int FoundationMarks1 { get => FoundationMarks; set => FoundationMarks = value; }
        public int WebBasicMarks1 { get => WebBasicMarks; set => WebBasicMarks = value; }
        public int DotNetMarks1 { get => DotNetMarks; set => DotNetMarks = value; }
        public float TotalMarks1 { get => TotalMarks; set => TotalMarks = value; }
        public float ObtainedMarks1 { get => ObtainedMarks; set => ObtainedMarks = value; }
        public float Percentage1 { get => Percentage; set => Percentage = value; }


        public void calcomarks()
        {
            ObtainedMarks = FoundationMarks + WebBasicMarks + DotNetMarks;
        }
        public void calcpercentage()
        {
            Percentage = (ObtainedMarks / TotalMarks) * 100;

        }
        public float retperc()
        {
            return Percentage;
        }


    }
}
