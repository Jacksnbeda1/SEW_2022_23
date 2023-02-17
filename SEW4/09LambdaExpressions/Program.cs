Func<int,int,int> addition = (x,y) => {return x + y; };
Func<int,int,int> subtract = (x,y) => x - y;    //return Anweisung kann auch weggelassen werden, eird implizit generiert

Func<string,string,string> concat = (x, y) => x + " " + y;

Action<int, int> printAddition = (x, y) => Console.WriteLine(x + " + " + y + " = " + addition(x, y));

Action<int> incrementAndPrint = (x) =>
{
    x++;
    Console.WriteLine(x);
};

Action printHelloWorld = () => Console.WriteLine("Hello World");        //kein Parameter


int result = addition(4,5);
Console.WriteLine(result);
Console.WriteLine(concat("Thomas", "Riegler"));
printAddition(4,5);

incrementAndPrint(100);
printHelloWorld();