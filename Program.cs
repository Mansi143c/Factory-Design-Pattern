////////////////////////////////////////////////////Simple Factory////////////////////////////////////////////////
/*
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
*/


////////////////////////////////////////////////////Factory Method////////////////////////////////////////////////
ShoeCreater shoeCreater = new NikeStore();
shoeCreater.SellShoe();

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
    public void make() => Console.WriteLine("Puma");

}

abstract class ShoeCreater {
    public abstract IShoe CreateShoe();
    public void SellShoe()  {
        IShoe shoe = CreateShoe();
        shoe.make();
    }

}

class NikeStore : ShoeCreater
{
    public override IShoe CreateShoe()
    {
        return new Nike();   
    }
}

class PumaStore : ShoeCreater
{
    public override IShoe CreateShoe()
    {
        return new Puma();
    }
}