using System;

namespace Farmacie
{
    class Program
    {
        static void Main(string[] args)
        {

            Medicamente m1 = new Medicamente("NUROFEN", 20);
            string s1=m1.Afisare();
            Console.WriteLine(s1);
        
        }
    }
}
