using _11Interfaces;

List<IHotDrink> hotDrinks = new List<IHotDrink>();

hotDrinks.Add(new Coffee("Espresso"));
hotDrinks.Add(new Tea("JagaTea"));
hotDrinks.Add(new Coffee("Melange"));
hotDrinks.Add(new Tea("Fruit Tea"));
//hotDrinks.Add(new EnergyDrink("Red Bull"));  // nicht möglich, weil Interface IHotDrink nicht implementiert.

foreach (IHotDrink element in hotDrinks)
{
	while (element.Degree < 60)		//Degreee ist bestandteil des Interfaces
	{
		element.cool();				//cool ist bestandteil des INterfaces
	}
}
foreach(IHotDrink element in hotDrinks) 
{
	Console.WriteLine(element);
}

List<IHasCaffeine> caffeineDrinks = new List<IHasCaffeine>();

caffeineDrinks.Add(new EnergyDrink("Red Bull"));
caffeineDrinks.Add(new EnergyDrink("Monster"));
caffeineDrinks.Add(new Coffee("Espresso"));

Console.WriteLine("Getränke mit Koffeingehalt < 200mg");
foreach (IHasCaffeine element in caffeineDrinks)
{
	if (element.Caffeine < 200)
	{
		Console.WriteLine(element);
	}

}