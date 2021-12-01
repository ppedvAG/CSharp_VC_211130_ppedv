
namespace Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            double summe = Addiere(45.78, -78);
            Console.WriteLine(summe);

            summe = BildeSumme(3.5, 56.89, 789, 12, -78);
            Console.WriteLine(summe);

            summe = Subtrahiere(10, 7, d:789);

            summe = AddiereUndSubtrahiere(15, 12, out int diff);

            Console.WriteLine("Summe: " + summe);
            Console.WriteLine("Differenz: " + diff);

            string eingabe = Console.ReadLine();
            if(int.TryParse(eingabe, out int result))
            {
                Console.WriteLine(result * 2);
            }
        }


        static int Addiere(int a, int b)
        {
            return a + b;
        }

        static double Addiere(double a, double b)
        {
            return a + b;
        }

        static double BildeSumme(params double[] summanden)
        {
            double summe = 0.0;

            foreach (double item in summanden)
            {
                summe += item;
            }

            return summe;
        }

        static double Subtrahiere(double a, double b, double c = 0, double d = 0)
        {
            return a - b - c - d;
        }

        static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }
    }
}