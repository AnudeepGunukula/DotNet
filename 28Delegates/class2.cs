using System;
namespace _28Delegates
{
    public delegate void SampleDelegate();
    public class class2
    {
        public static void SampleMethodOne()
        {
            System.Console.WriteLine("Sample Method One");
        }

        public static void SampleMethodTwo()
        {
            System.Console.WriteLine("Sample Method Two");
        }
        public static void SampleMethodThree()
        {
            System.Console.WriteLine("Sample Method Three");
        }


        static void Main(string[] args)
        {
            SampleDelegate sd1, sd2, sd3, sd4;

            sd1 = SampleMethodOne;
            sd2 = SampleMethodTwo;
            sd3 = SampleMethodThree;

            // sd1();
            // sd2();
            // sd3();
            sd4 = sd1 + sd2 + sd3;  //chaining delegates

            //if chaining is done for return type methods then the last method return will be returned by delegate
            sd4();
            sd4 -= sd2;
            sd4();

        }

    }
}