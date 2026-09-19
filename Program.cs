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
/*ShoeCreater shoeCreater = new NikeStore();
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
*/

////////////////////////////////////////////////////Abstract Factory////////////////////////////////////////////////
productCreater pc = new NikeStore();
pc.sellProduct();
interface IShoe
{
    void make(); 
}
interface ITshirts
{
    void make();
}

class NikeShoe : IShoe
{
    public void make() { Console.WriteLine("Nike Shoe"); }
}

class NikeTshirts : ITshirts
{
    public void make() { Console.WriteLine("Nike TShirts"); }
}


class PumaShoe : IShoe
{
    public void make() { Console.WriteLine("Puma Shoe"); }
}

class PumaTshirts : ITshirts
{
    public void make() { Console.WriteLine("Puma TShirts"); }
}


abstract class productCreater
{
    public abstract IShoe getShoe();
    public abstract ITshirts getTShirt();
    public void sellProduct()
    {
        IShoe shoeProduct = getShoe();
        ITshirts tShirtProduct = getTShirt();
        shoeProduct.make();
        tShirtProduct.make();
    }
}

class NikeStore : productCreater
{
    public override IShoe getShoe()
    {
        return new NikeShoe();
    }
    public override ITshirts getTShirt()
    {
        return new NikeTshirts();
    }
}

class PumaStore : productCreater
{
    public override IShoe getShoe()
    {
        return new PumaShoe();
    }
    public override ITshirts getTShirt()
    {
        return new PumaTshirts();
    }
}