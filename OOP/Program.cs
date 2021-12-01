
namespace OOP
{
    class Programm
    {
        static void Main(string[] args)
        {
            Person neuePerson = new Person("Maria", "Fischer", new DateTime(1994, 12, 5));
            Person neuePerson2 = new Person("Otto", "Meier", new DateTime(1976, 4, 12));

            Console.WriteLine(neuePerson.Vorname);

            neuePerson.Vorname = "Markus";
            Console.WriteLine(neuePerson.Vorname);

            Console.WriteLine(neuePerson.AlterInJahren);
            neuePerson.KorrigiereGeburtsdatumUmEinJahr();
            Console.WriteLine(neuePerson.AlterInJahren);
        }
    }
}
