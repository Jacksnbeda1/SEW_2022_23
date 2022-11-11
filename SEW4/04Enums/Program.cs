DayOfWeek dayOfWeek = DayOfWeek.Monday;
Classes bestClassOfFJ = Classes._4IT;

Console.WriteLine("Beste KLasse des FJ: " + bestClassOfFJ);
Console.WriteLine("Beste KLasse des FJ: " + (int)bestClassOfFJ);
Console.WriteLine("Red: " + Color.RED);
Console.WriteLine("Red: " + (int)Color.RED);

public enum Classes { _1IT, _2IT, _4IT, _5IT }

public enum Color { RED = 16711680, Green = 65280, Blue = 255}           //Red: 255 0 0, #FF 00 00