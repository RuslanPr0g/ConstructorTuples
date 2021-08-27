using System;
using TP.Examples;

namespace TuplesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var friend = new DeconstructClass("Thomas", "Claudius", "Huber");

            var (first, middle, last) = friend; // this thing calls the Deconstruct() method

            Console.WriteLine(first);
            Console.WriteLine(middle);
            Console.WriteLine(last);
        }
    }
}
