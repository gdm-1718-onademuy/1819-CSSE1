using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            VormFactory vormFactory = new VormFactory();
            IVorm vormA = vormFactory.GetVorm("Cirkel");
            vormA.Teken();
        }
    }
}