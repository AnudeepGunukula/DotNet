using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab13code6
{
    [Serializable]
    class Student : ISerializable
    {
        private int rollNo;
        private string name;
        private string city;
        private string degree;

        public int RollNo { get => rollNo; set => rollNo = value; }
        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public string Degree { get => degree; set => degree = value; }



        public Student(int rollno, string name, string city, string degree)
        {
            this.rollNo = rollno;
            this.name = name;
            this.city = city;
            this.degree = degree;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("rollNo", rollNo);
            info.AddValue("name", name);
            info.AddValue("city", city);
            info.AddValue("degree", degree);
        }

        public Student(SerializationInfo info, StreamingContext context)
        {

            rollNo = (int)info.GetValue("rollno", typeof(int));
            name = (string)info.GetValue("name", typeof(string));
            city = (string)info.GetValue("city", typeof(string));
            degree = (string)info.GetValue("degree", typeof(string));

        }
    }
}
