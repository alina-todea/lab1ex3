using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura
            */

            Console.WriteLine("introduceti un numar intreg");
            int numar = int.Parse(Console.ReadLine());

            int ultimaCifra = numar % 10;
            Console.WriteLine("ultima cifra a numarului " + numar + " este:  "  + ultimaCifra);

        }
    }
}