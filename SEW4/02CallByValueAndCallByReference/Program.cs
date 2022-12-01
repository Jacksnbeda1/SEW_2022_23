using _02CallByValueAndCallByReference;

void SwapD(double a, double b)
{
    double temp = a;
    a = b;
    b = temp;
}

void SwapDRef(ref double a, ref double b)
{
    double temp = a;
    a = b;
    b = temp;
}
void SwapS(Student a, Student b)
{
    Student temp = a;
    a = b;
    b = temp;
}

void SwapSRef(ref Student a, ref Student b)
{
    Student temp = a;
    a = b;
    b = temp;
}

void generateNumbers(out int a, out int b)
{
    a = 100;
    b = 200;
}

void generateNumberArray(out int[] numbers)
{
    numbers = new int[100];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = i * i;
    }
}
double a = 5.0;
double b = 3.5;

SwapD(a, b); // call by value

Console.WriteLine("a: " + a);
Console.WriteLine("b: " + b);

SwapDRef(ref a, ref b); // call by reference


Console.WriteLine("a: " + a);
Console.WriteLine("b: " + b);


Student felix = new Student() { FirstName = "Felix", LastName = "Heidegger" };
Student benedikt = new Student() { FirstName = "Benedikt", LastName = "Hager" };

SwapS(felix, benedikt);     // call by value
Console.WriteLine("Felix: " + felix);
Console.WriteLine("Benedikt: " + benedikt);
SwapSRef(ref felix, ref benedikt);
Console.WriteLine("Felix: " + felix);
Console.WriteLine("Benedikt: " + benedikt);

int x;
int y;
//Console.WriteLine(x) Variable kann noch nicht verwendet werden --> nicht initialisiert
generateNumbers(out x, out y);  //nach Aufruf sind die Variablen initialisiert!!!!!!
Console.WriteLine("x: " + x);
Console.WriteLine("y: " + y);

int[] myNumbers;
generateNumberArray(out myNumbers);

for (int i = 0; i < myNumbers.Length; i++)
{
    Console.WriteLine(myNumbers[i]);
}