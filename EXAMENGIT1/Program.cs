// Basisklasse met eigenschap naam, leven en roll
class Person
{
    public string Naam { get; set; }
    public int Leven { get; set; }
    public string Roll { get; set; }
    public string SpecialeKracht { get; set; }

    public Person(string naam, int leven, string roll, string specialeKracht)
    {
        Naam = naam;
        Leven = leven;
        Roll = roll;
        SpecialeKracht = specialeKracht;
    }

    public virtual void ToonInfo()
    {
        Console.WriteLine($"Naam: {Naam}");
        Console.WriteLine($"Leven: {Leven}");
        Console.WriteLine($"Roll: {Roll}");
        Console.WriteLine($"Speciale kracht: {SpecialeKracht}");
    }
}

// Afgeleide klasse die inheritance gebruikt
class Personage : Person
{
    public Personage(string naam, int leven, string roll, string specialeKracht)
        : base(naam, leven, roll, specialeKracht)
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
        var mijnPersonage = new Personage("Arend", 100, "Strijder", "Vuurstorm");
        mijnPersonage.ToonInfo();
    }
}
