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
            Medicamente m2 = new Medicamente("Paracetamol,11");// Constructor sir de caractere
            string s2 = m2.Afisare();
            Console.WriteLine(s2);
            Console.WriteLine(m2.Compara(m1));
            Console.WriteLine("Introduceti denumirea si pretul: ");
            Medicamente m3 = new Medicamente(Console.ReadLine(),Convert.ToDouble(Console.ReadLine()));
            string s3 = m3.Afisare();
            Console.WriteLine(s3);
        }
    }
}
