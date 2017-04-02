using System;

namespace UnicamMath
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("TRIANGOLO RETTANGOLO");
            Console.WriteLine("Questo programma calcola l'ipotenusa e gli angoli interni fornendo la lunghezza di due cateti");

            Console.Write("Inserisci la lunghezza del primo cateto: ");
            string cateto1Testuale = Console.ReadLine();

            Console.Write("Inserisci la lunghezza del secondo cateto: ");
            string cateto2Testuale = Console.ReadLine();

            double  ipotenusa = 0,
                    cateto1 = 0,
                    cateto2 = 0;
            double.TryParse(cateto1Testuale, out cateto1);
            double.TryParse(cateto2Testuale, out cateto2);
            double  angolo1 = 90,
                    angolo2 = Math.Atan(cateto1/cateto2)*(180/Math.PI),
                    angolo3 = 90 - angolo2;

            ipotenusa = Math.Sqrt(Math.Pow(cateto1,2.0)+Math.Pow(cateto2,2.0));

            Console.WriteLine($"L'ipotenusa misura {ipotenusa.ToString("F2")}");
            Console.WriteLine($"I tre angoli interni misurano {angolo1.ToString("F2")} gradi, {angolo2.ToString("F2")} gradi e {angolo3.ToString("F2")} gradi.");

            Console.ReadKey();
        }
    }
}
