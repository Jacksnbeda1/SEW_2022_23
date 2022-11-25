static int Addition(int x, int y)
{
    return x + y;
}
static int Subtraction(int x, int y)
{
    return  x - y;
}

static int Multiplication(int x, int y)
{
    return (x * y);
}
static void PrintWithLeadingSpaces(int x)
{
    Console.WriteLine("    " + x);
}

static void PrintWithLeading0(int x)
{
    Console.WriteLine("0000" + x);
}

Rechenoperation operation = new Rechenoperation(Addition); // new Rechenoperation --> lange Schreibweise

int result = operation(4, 5);
Console.WriteLine("Ergebnis: " + result);

operation = new Rechenoperation(Subtraction);

result = operation(4, 5);
Console.WriteLine("Ergebnis: " + result);

operation = Multiplication;             //kurze Schreibweise einer Zuweisung zu einem Delegate

result = operation(4, 5);
Console.WriteLine("Ergebnis: " + result);


Printer printer = PrintWithLeadingSpaces;
printer(99);
Console.WriteLine("-------------------------------------------");
printer += PrintWithLeading0;       //weitere zusätzliche Methode zuweisen
printer(66);
Console.WriteLine("-------------------------------------------");
printer -= PrintWithLeadingSpaces;
printer(55);
printer -= PrintWithLeading0;           // alle Methoden wurden abgemeldet --> printer ist null

if (printer != null)
{
    printer(44);
}



// definition des delegates am Ende der Datei (nur im Hauptprogramm)
public delegate int Rechenoperation(int x, int y);          //definition eines neuen Datentyps (delegates)

public delegate void Printer(int x);





