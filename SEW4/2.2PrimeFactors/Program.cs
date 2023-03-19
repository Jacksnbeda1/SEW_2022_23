using _2._2PrimeFactors;

PrimeNumber primeNumber = new PrimeNumber();
PrimeNumber primeNumber1 = new PrimeNumber();

primeNumber.PrimeFactorFound += PrimFaktor;

primeNumber.GeneratePrimeFactorsAsync(275);
primeNumber1.GeneratePrimeFactorsAsync(275);


void PrimFaktor(int primFaktor)
{
   Console.WriteLine(primFaktor);
}

primeNumber1.PrimeFactorFound += (primFaktor) => Console.WriteLine(primFaktor);