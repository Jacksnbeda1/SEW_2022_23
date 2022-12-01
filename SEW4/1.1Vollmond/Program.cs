using _1._1Vollmond;


internal class Program
{
    private static void Main(string[] args, MoonPhases moonPhases)
    {
        DateTime dt = DateTime.Now;
        MoonPhases mp = MoonPhases.Newmoon;


        while (true)
        {
            Moon.GetMoonPhase(dt, ref mp);

            MoonPhases MoonPhases;
            if (moonPhases == MoonPhases.Fullmoon)
            {
                Console.WriteLine(dt);
            }
            else
            {
                dt.AddDays(1);
            }
        }
    }
}


