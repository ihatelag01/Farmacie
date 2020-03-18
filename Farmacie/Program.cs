using System;

namespace Farmacie
{
    class Program
    {
        static void Main(string[] args)
        {

            Medicamente m1 = new Medicamente("Nurofen", 20);// Constructor paramatrii
            string s1=m1.Afisare();
            Console.WriteLine(s1);
            Medicamente m2 = new Medicamente("Paracetamol,152");// Constructor sir de caractere
            string s2 = m2.Afisare();
            Console.WriteLine(s2);
        }
    }
}
