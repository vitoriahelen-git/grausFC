using System;

namespace grausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorc;
            double valorf;

            Console.WriteLine("Coversão de temperatura");
            Console.Write("°F: ");
            valorf = Convert.ToDouble(Console.ReadLine());
            valorc = (valorf - 32)/1.8;
            Console.WriteLine($"O {valorf} equivalem a {valorc}° ");

        }
    }
}
