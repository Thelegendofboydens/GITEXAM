// Basisklasse met eigenschap naam, leven en roll
class Person
{
    public string Naam { get; set; }
    public int Leven { get; set; }
    public string Roll { get; set; }

    public Person(string naam, int leven, string roll)
    {
        Naam = naam;
        Leven = leven;
        Roll = roll;
    }

    public virtual void ToonInfo()
    {
        Console.WriteLine($"De naam van het personage is {Naam}.");
        Console.WriteLine($"Leven: {Leven}");
        Console.WriteLine($"De rol van het personage is {Roll}.");
    }
}

// Afgeleide klasse die inheritance gebruikt
class Personage : Person
{
    public Personage(string naam, int leven, string roll)
        : base(naam, leven, roll)
    {
    }

    public override void ToonInfo()
    {
        Console.WriteLine("Personagegegevens:");
        base.ToonInfo();
    }
}

// Maak een object van de klasse Personage en toon de gegevens
class Program
{
    static void Main()
    {
        var mijnPersonage = new Personage("Arend", 100, "Strijder");
        mijnPersonage.ToonInfo();
    }
}
