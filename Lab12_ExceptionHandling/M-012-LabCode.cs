using System;

namespace LabCode
{
    public enum Rechenoperation { Addition = 1, Subtraktion, Multiplikation, Division }

    class Program
    {
        //F�ge in die Main()-Methode eine Try/Catch-Mechanik ein, welche mindestens v�er verschiedene Exceptions abf�ngt und dem Benutzer eine
        //sinnvolle Fehlermeldung ausgibt. Etabliere zudem eine Mechanik, welche das Programm im Fehlerfall wiederholt.
        static void Main(string[] args)
        {
            string eingabe = GetEingabe();

            Term term = new Term(eingabe);

            int ergebnis = BerechneTerm(term);

            Console.WriteLine($"\t={ergebnis}");
        }

        //Code�nderungen sollen nur in der Main()-Methode stattfinden.
        static string GetEingabe()
        {
            Console.WriteLine("Bitte gib einen Term mit zwei Zahlen und einem Grundrechenoperator (+ - * /) ein (z.B.: 25+13):");
            return Console.ReadLine();
        }

        static int BerechneTerm(Term term)
        {
            switch (term.Operation)
            {
                case Rechenoperation.Addition:
                    return term.Zahl1 + term.Zahl2;
                case Rechenoperation.Subtraktion:
                    return term.Zahl1 - term.Zahl2;
                case Rechenoperation.Multiplikation:
                    return term.Zahl1 * term.Zahl2;
                default:
                    return term.Zahl1 / term.Zahl2;
            }
        }
    }

    class Term
    {
        public string Eingabe { get; set; }
        public int Zahl1 { get; set; }
        public int Zahl2 { get; set; }
        public Rechenoperation Operation { get; set; }

        public Term(string term)
        {
            this.Eingabe = term;
            this.Operation = this.GetRechenoperation();

            string[] zahlen = this.SplitTerm();

            this.Zahl1 = int.Parse(zahlen[0]);
            this.Zahl2 = int.Parse(zahlen[1]);
        }

        private Rechenoperation GetRechenoperation()
        {
            if (this.Eingabe.Contains('+'))
                return Rechenoperation.Addition;
            else if (this.Eingabe.Contains('-'))
                return Rechenoperation.Subtraktion;
            else if (this.Eingabe.Contains('*'))
                return Rechenoperation.Multiplikation;
            else if (this.Eingabe.Contains('/'))
                return Rechenoperation.Division;
            else
                return 0;
        }

        private string[] SplitTerm()
        {
            switch (this.Operation)
            {
                case Rechenoperation.Addition:
                    return this.Eingabe.Split('+');
                case Rechenoperation.Subtraktion:
                    return this.Eingabe.Split('-');
                case Rechenoperation.Multiplikation:
                    return this.Eingabe.Split('*');
                case Rechenoperation.Division:
                    return this.Eingabe.Split('/');
            }
            return null;
        }
    }
}
