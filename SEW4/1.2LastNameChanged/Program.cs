using System;
using _1._2LastNameChanged;


internal class Program
{
    private static void Main(string[] args)
    {
        Person anna = new Person("Anna", "Nass");
        Person ben = new Person("Ben", "Utzer");
        Person theo = new Person("Theo", "Logie");

        ben.LastNameChanged += LastNameChanged;
        anna.LastNameChanged += LastNameChanged;

        ben.LastName = "Zien";
        theo.LastName = "Retisch";

        void LastNameChanged(object? sender, EventArgs e)
        {
            Person p = (Person)sender;
            Console.WriteLine("Der Nachname von " + p.FirstName + " " + p.LastName + " hat sich geändert.");
        }

        Console.ReadLine();
    }
}