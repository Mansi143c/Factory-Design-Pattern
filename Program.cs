////////////////////////////////////////////////////Simple Factory////////////////////////////////////////////////

IShoe s = ShoeFactory.GetShoe("Addidas");
s.make();
interface IShoe
{
    void make();
}

class Nike : IShoe
{
   public void make() => Console.WriteLine("Nike"); 
}

class Puma : IShoe
{
    public void make() => Console.WriteLine($"Puma");
}

class ShoeFactory
{
    public static IShoe GetShoe(string shoe)
    {
        if (shoe == "Nike")
        {
            return new Nike();
        }
        if (shoe == "Puma")
        {
            return new Puma();
        }

        throw new ArgumentException("Invalid shoe type");

    }
}



