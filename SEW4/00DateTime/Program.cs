using System;

namespace _20DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToLongTimeString());
            Console.WriteLine("Jahr: " + dt.Year);
            Console.WriteLine("Month: " + dt.Month);
            Console.WriteLine("Tag: " + dt.Day);
            Console.WriteLine("Stunde: " + dt.Hour);
            //Änderung
            Console.WriteLine("Minute: " + dt.Minute);
            Console.WriteLine("Sekunde: " + dt.Second);
            Console.WriteLine("Millisekunde: " + dt.Millisecond);
            Console.WriteLine("Wochentag: " + dt.DayOfWeek);

            DateTime Geburtstag = new DateTime(2005, 3, 2);
            Console.WriteLine("Mein Geburtstag: " + Geburtstag.ToLongDateString());
            Console.WriteLine("Wochentag meiner Geburt: " + Geburtstag.DayOfWeek);
            Console.WriteLine("Mein Alter in Tagen: " + (dt - Geburtstag).TotalDays.ToString("#.##"));
            Console.WriteLine("Mein Alter in Sekunden: " + (dt - Geburtstag).TotalSeconds.ToString("#.##"));

            DateTime ferien = new DateTime(2021, 7, 3);
            Console.WriteLine("Tage bis Ferienbeginn: " + MathF.Round((float)(ferien - dt).TotalDays).ToString("#.##"));

            Console.Write("Bitte ein Datum eingeben: ");
            string input = Console.ReadLine();
            DateTime date = DateTime.Parse(input);
            Console.WriteLine("Das eingegebene Datum war: " + date.ToShortDateString());
        }
    }
}