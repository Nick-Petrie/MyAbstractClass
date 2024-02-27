abstract class Sandwich
{
    // Property
    public abstract string Protein { get; set; }
    // Methods
    public abstract string Describe();

}

class Archies : Sandwich
{
    public string Pickles { get; set; }
    public string Cheese { get; set; }
    public string Bun {  get; set; }
    public string Sauce { get; set; }

    public string Veggies { get; set; }

    public override string Protein { get; set; }

    public override string Describe()
    {
        return $"Archie's has a sandwich with {Protein}, {Pickles}, {Cheese}, {Veggies}, {Sauce} all on a toasted {Bun}!";
    }
    public Archies()
    {
        Pickles = "home maded pickles";
        Protein = "local beefalo";
        Cheese = "cheddar";
        Veggies = "carmelized onions";
        Sauce = "house made signature sauce";
        Bun = "brioche bun";
    }

    public Archies(string protein, string pickles, string cheese, string veggies, string sauce, string bun)
    {
        Protein = protein;
        Pickles= pickles;
        Cheese = cheese;
        Veggies= veggies;
        Sauce = sauce;  
        Bun = bun;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Archies sandwich1 = new Archies();

        Archies sandwich2 = new Archies("parmesan encrusted chicken", "no pickles", "gruyere", "no veggies", "sundried tomato aioli", "toasted brioche bun");

        Console.WriteLine(sandwich1.Describe());
        Console.WriteLine(sandwich2.Describe());
    }
}