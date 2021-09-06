using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3code3
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double saleprice;
        public Car()
        {

        }
        public Car(string make, string model, int year, double saleprice)
        {

        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Saleprice { get => saleprice; set => saleprice = value; }


    }
}
