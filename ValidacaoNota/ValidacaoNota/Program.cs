using System;
using System.Globalization;

namespace ValidacaoNota
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (n1 < 0.0 || n1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (n2 <0.0 || n2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double media = (n1 + n2) / 2.0;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            
        }   
    }
}
