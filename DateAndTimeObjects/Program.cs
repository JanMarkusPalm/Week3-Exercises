using System;

namespace DateAndTimeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine(current.ToString(" dddd dd MMM"));
            Console.WriteLine(current.ToString());




            /*
            Console.WriteLine(current.Year);
            Console.WriteLine(current.Month);
            Console.WriteLine(current.Hour);
            Console.WriteLine(current.Minute);
            Console.WriteLine(current.Second);
            Console.WriteLine(current.Millisecond);
            */


        }
    }
}
