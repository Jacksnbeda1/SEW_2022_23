using _1._4PrimeNumbersAsync;
{
    // Erzeuge ein PrimeNumber-Objekt
    PrimeNumber primeNumber = new PrimeNumber();

    // Melden Sie sich für das PrimeNumberFound-Event an
    primeNumber.PrimeNumberFound += number => Console.WriteLine($"{number} ist eine Primzahl.");

    // Generieren Sie Primzahlen von 1 bis 100 (asynchron)
    primeNumber.GeneratePrimeNumbersAsync(1, 100).Wait();

    // Erzeuge ein weiteres PrimeNumber-Objekt
    PrimeNumber primeNumber2 = new PrimeNumber();

    // Konsumieren Sie das PrimeNumberFound-Event als Lambda-Ausdruck
    primeNumber2.PrimeNumberFound += number => Console.WriteLine($"{number} ist ebenfalls eine Primzahl.");

    // Generieren Sie Primzahlen von 100 bis 200 (asynchron)
    primeNumber2.GeneratePrimeNumbersAsync(100, 10000).Wait();
}


//using primenumbers_2_2;

//int startnumber;
//int endnumber;

//primenumber primenumber = new primenumber();

//primenumber.primenumberfound += prim => console.writeline(prim.tostring() + " is a prime number!");

//console.writeline("for the search of a prime number you have to define a start and a end number.");
//while (true)
//{
//    console.write("enter a start number: ");
//    if (int.tryparse(console.readline(), out startnumber))
//    {
//        break;
//    }
//}
//while (true)
//{
//    console.write("enter a end number: ");
//    if (int.tryparse(console.readline(), out endnumber))
//    {
//        break;
//    }
//}

//console.writeline("search for prime numbers between {0} and {1} started!", startnumber, endnumber);
//task t = primenumber.generateprimenumbersasync(startnumber, endnumber);

//t.wait();
//console.writeline("search for prime numbers between {0} and {1} finished!", startnumber, endnumber);